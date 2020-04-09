using DPU_Soft.BLL.Functions;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavSalonForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable
{
    public partial class SinavSalonBilgileriTable : BaseTablo
    {
        public SinavSalonBilgileriTable()
        {
            InitializeComponent();
            Bll = new SinavSalonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((SinavSalonBilgileriBll)Bll).List(x => x.SinavKayitId == OvnerForm.Id).ToBindingList<SinavSalonBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<SinavSalonBilgileriL>().Where(x=> !x.Delete).Select(x => x.SinavSalonu_Id).ToList();

            var entities = ShowListforms<SinavSalonuListForm>.ShowDialogListForm(KartTuru.SinavSalonBilgiKayit,ListeDisiTutulacakKayitlar, true, false).EntityListConvert<SinavSalonuEntity>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new SinavSalonBilgileriL
                {
                    SalonAdi = entity.SalonAdi,
                    SinavKayitId =OvnerForm.Id,
                    SinavSalonu_Id=entity.Id,
                    SalonKapasitesi=entity.SalonKapasitesi,
                    GozetmenSayisi=entity.GozetmenSayisi,
                    
                    
                    Insert = true
                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colSalonAdi;

            ButonenableDurumu(true);
        }


    }
}
