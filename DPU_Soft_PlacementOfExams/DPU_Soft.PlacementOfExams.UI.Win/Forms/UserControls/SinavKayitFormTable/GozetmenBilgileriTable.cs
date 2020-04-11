using DevExpress.Data;
using DPU_Soft.BLL.Functions;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System.Linq;
using System.Windows.Forms;
using DPU_Soft.PlacementOfExams.Common.Massage;


namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable
{
    public partial class GozetmenBilgileriTable : BaseTablo
    {
        public GozetmenBilgileriTable()
        {
            InitializeComponent();
            Bll = new GozetmenBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }


        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((GozetmenBilgileriBll)Bll).List(x => x.SinavKayitId == OvnerForm.Id).ToBindingList<GozetmenBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<GozetmenBilgileriL>().Where(x => !x.Delete).Select(x => x.GozetmenId).ToList();

            var entities = ShowListforms<GozetmenListForm>.ShowDialogListForm(KartTuru.GozetmenBilgiKayit, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<GozetmenEntity>();
            if (entities == null) return;

            try
            {
                foreach (var entity in entities)
                {
                    var row = new GozetmenBilgileriL
                    {
                        GozetmenAdi = entity.GozetmenAdi,
                        GorevlendirmeSayisi = entity.GorevlendirmeSayisi + 1,
                        GozetmenId = entity.Id,
                        SinavKayitId = OvnerForm.Id,
                        Insert = true
                    };
                    source.Add(row);

                }
            }
            catch (System.Exception)
            {

                
            }
            
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colGozetmenAdi;

            
            Kaydet();
            ButonenableDurumu(true);
        }



    }
}
