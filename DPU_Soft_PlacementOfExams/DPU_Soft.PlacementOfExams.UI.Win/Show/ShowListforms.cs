using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
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

<<<<<<< HEAD
=======
        public static void ShowListForm(KartTuru kartTuru,params object[]prm)
        {
            //yetki Kontrolü Yapılacak
            var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }


>>>>>>> yandal
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
    }
}
