using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using DPU_Soft.BLL.General;
using System.Linq;
using DPU_Soft.PlacementOfExams.Model.Dto;
using System.Collections.Generic;
using DPU_Soft.PlacementOfExams.Common.Massage;
using System.Windows.Forms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class SubeDonemSecimiEditForm : BaseEditForm
    {
        private readonly long _kullaniciId;
        private readonly bool _subeSecimButonunaBasildi;
        private readonly long _seciliGelecekSubeId;
        private readonly long _seciliGelecekDonemId;
        private bool _girisButonunaBasildi;

        private List<long> _yetkiliOlunanSubeler;
        public SubeDonemSecimiEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = dpuDataLayoutControl;

            HideItems = new BarItem[] { btnYeni, btnKaydet, btnSil, btnGeriAl,btnGeriAl};
            ShowItems = new BarItem[] { btnGiris };
            subeNavigator.Navigator.NavigatableControl = subeGrid;
            donemNavigator.Navigator.NavigatableControl = donemGrid;

            EventsLoad();

            _kullaniciId = (long)prm[0];
            _subeSecimButonunaBasildi = (bool)prm[1];
            _seciliGelecekSubeId=(long)prm[2];
            _seciliGelecekDonemId = (long)prm[3];
        }

        public override void Yukle()
        {
            using (var bll=new KullaniciBirimYetkileriBll())
            {
                var yetkiler = bll.List(x => x.KullaniciId == _kullaniciId).Cast<KullaniciBirimYetkileriL>().ToList();
                _yetkiliOlunanSubeler = yetkiler.Where(x => x.SubeId > 0).Select(x=>x.SubeId.Value).ToList();

                var subeSource= yetkiler.Where(x => x.SubeId > 0).ToList();
                var donemSource = yetkiler.Where(x => x.DonemId > 0).ToList();

                if (subeSource.Count==0)
                {
                    Messages.HataMesaji("Kullanıcıya Fakülte Yetkisi Verilmediği için Giriş Yapılamaz");
                    Application.ExitThread();
                }
                if (donemSource.Count == 0)
                {
                    Messages.HataMesaji("Kullanıcıya Dönem Yetkisi Verilmediği için Giriş Yapılamaz");
                    Application.ExitThread();
                }

                subeGrid.DataSource = subeSource;
                donemGrid.DataSource = donemSource;

                if (!_subeSecimButonunaBasildi) return;
                subeTablo.RowFocus("SubeId", _seciliGelecekSubeId);
                donemTablo.RowFocus("DonemId", _seciliGelecekDonemId);

            }
        }

        protected override void Giris()
        {
            var sube= subeTablo.GetRow<KullaniciBirimYetkileriL>();
            var donem = donemTablo.GetRow<KullaniciBirimYetkileriL>();

            using (var bll=new DonemBll())
            {
                var entity = (DonemEntity)bll.Single(x=>x.Id==donem.DonemId);
                if (entity==null)
                {
                    Messages.HataMesaji("Seçtiğiniz fakütleye dönem tanımlaması yapılmamıştır.");
                    return;
                }
                AnaForm.Donem = entity;
                AnaForm.YetkiliOlunanSubeler = _yetkiliOlunanSubeler;
                AnaForm.SubeId = sube.SubeId.Value;
                AnaForm.SubeAdi = sube.SubeAdi;
                AnaForm.DonemId = donem.DonemId.Value;
                AnaForm.DonemAdi = donem.DonemAdi;

            }

            _girisButonunaBasildi = true;
            Close();
        }

        protected override void Control_KeyDown(object sender, KeyEventArgs e)
        {
            base.Control_KeyDown(sender, e);
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Right && e.KeyCode != Keys.Left) return;
            if (sender == subeGrid)
                donemGrid.Focus();
            else
                subeGrid.Focus();
            
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.BaseEditForm_FormClosing(sender, e);

            if (_girisButonunaBasildi || _subeSecimButonunaBasildi) return;

            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor Musunuz", "Çıkış Onayı") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}