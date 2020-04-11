using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Show
{
    public class ShowListforms<TForm> where TForm:BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            //yetki Kontrolü Yapılacak
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForm(KartTuru kartTuru,params object[]prm)
        {
            //yetki Kontrolü Yapılacak
            var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }


        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            //Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SecilenEntity : null;
            }
        }
        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {


            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SecilenEntities : null;
            }
        }
        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiSelect, params object[] prm)
        {


            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                    frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SecilenEntities : null;
            }
        }
        public static IEnumerable<IBaseEntity>ShowDialogListForm(IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
        

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SecilenEntities: null;
            }
        }

        public static void ShowDialogListForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.AktifPasifButonGoster = true;
                frm.Yukle();
                frm.ShowDialog();
                
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm2(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SecilenEntities : null;

            }
        }


    }
}
