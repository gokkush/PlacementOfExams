using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Show.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public long ShowDialogeditForm(KartTuru kartTuru, long id, params object[] prm) 
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
    }
}
