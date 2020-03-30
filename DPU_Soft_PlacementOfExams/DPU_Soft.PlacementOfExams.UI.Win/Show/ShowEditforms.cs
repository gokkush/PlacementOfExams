using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Show.Interfaces;
using System;

namespace DPU_Soft.PlacementOfExams.UI.Win.Show
{
    public class ShowEditforms<TForm>:IBaseFormshow where TForm: BaseEditForm
    {
        public long ShowDialogeditForm(KartTuru kartTuru,long id)//, params object[] prm) 
        {
            //Yetki Kontrolü
            using (var frm=(TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        
        }

        public static long ShowDialogeditForm(KartTuru kartTuru, long id, params object[] prm) 
        {
            //Yetki Kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }

        }
        public static void ShowDialogEditForm(long? id, params object[] prm)
        {
            //Yetki Kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
            }

        }

        public static long ShowDialogEditForm(long id, params object[] prm)
        {
            //Yetki Kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }

        }
        public static bool ShowDialogEditForm(IslemTuru islemTuru, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            {
                frm.BaseIslemTuru = islemTuru;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak;
            }

        }
        public static void ShowDialogEditForm()
        {
            using (var frm=(TForm)Activator.CreateInstance(typeof(TForm)))
            {

                frm.Yukle();
                frm.ShowDialog();
            }

        }
        public static T ShowDialogEditForm<T>(params object[] prm) where T:IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }
        }
    }
}
