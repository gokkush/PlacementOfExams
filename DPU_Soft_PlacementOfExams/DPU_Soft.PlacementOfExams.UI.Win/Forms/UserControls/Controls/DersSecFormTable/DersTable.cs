using System.Data;
using System.Linq;
using System.Windows.Forms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms;
using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DersSecFormTable
{
    public partial class DersTable : BaseTablo
    {
        public DersTable()
        {
            InitializeComponent();
            Bll = new DersYetkiBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((DersYetkiBll)Bll).List(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId).ToBindingList<DersYetkiL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<DersYetkiL>().Select(x => x.DersId.Value).ToList();

            var entities = ShowListforms<DersListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true, false).EntityListConvert<DersEntity>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new DersYetkiL
                {
                    Kod=entity.Kod,
                    DersAdi=entity.DersAdi,
                    DonemId=AnaForm.DonemId,
                    DersId=entity.Id,
                    SubeId = AnaForm.SubeId,
                    Insert = true
                };

                source.Add(row);
            }
            if (!Kaydet()) return;
            Listele();
            tablo.Focus();
            //tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            //tablo.FocusedColumn = colSubeAdi;

            //ButonenableDurumu(true);
        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Ders") != DialogResult.Yes) return;

            tablo.GetRow<IBaseHareketEntity>().Delete = true;
            tablo.RefreshDataSource();

            var rowHandle = tablo.FocusedRowHandle;
            if (!Kaydet()) return;
            Listele();
            tablo.FocusedRowHandle = rowHandle;

        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            btnHareketSil.Enabled = tablo.DataRowCount > 0;
            btnHareketEkle.Enabled = true;
            e.SagMenuGoster(popupMenu);
        }

    }
}
