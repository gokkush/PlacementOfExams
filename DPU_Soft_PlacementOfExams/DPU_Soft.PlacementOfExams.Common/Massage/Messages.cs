
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.Common.Massage
{
    public  class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
           // AnaMessage.Mesaj("Hata", hataMesaji);
            XtraMessageBox.Show(hataMesaji,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
          
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçili {kartAdi} silinecektir. Onaylıyor musunuz?", "silme Onayı");
        }


    }
}
