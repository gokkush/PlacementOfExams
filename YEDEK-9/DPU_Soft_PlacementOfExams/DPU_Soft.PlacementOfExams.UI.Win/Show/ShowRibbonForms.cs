using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.UI.Win.Show
{
    public class ShowRibbonForms<TForm> where TForm:RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm);

            if (dialog)
            {
                using (frm)
                {
                    frm.ShowDialog();

                }

            }
            else
                frm.Show();
        }
    }
}
