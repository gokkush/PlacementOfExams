using System.Windows.Forms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DevExpress.XtraSplashScreen;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.Genelforms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable
{
    public partial class OgrenciListesiTable : BaseTablo
    {
        public OgrenciListesiTable()
        {
            InitializeComponent();
            Bll = new OgrenciBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OgrenciBilgileriBll)Bll).List(x => x.SinavKayitId == OvnerForm.Id).ToBindingList<OgrenciBilgileriL>();
        }

        protected override void HareketEkle()
        {
            Cursor.Current = Cursors.WaitCursor;
            var source = tablo.DataController.ListSource;
            OpenFileDialog opn = new OpenFileDialog();
            Microsoft.Office.Interop.Excel.Application _xlsUygulama;
            Microsoft.Office.Interop.Excel.Workbook _xlsKitap;
            Microsoft.Office.Interop.Excel.Worksheet _xlsSayfa;
            Microsoft.Office.Interop.Excel.Range _xlsHucre;
            int xlsRow;
            opn.Title = "Lütfen Öğrenci Listesinin Bulunduğu Excel Dosyasını Seçiniz!";
            opn.Filter = "Excel Dosyaları | *.xls ;*.xlsx"; //"(*.xlsx) | *.xlsx";//
            opn.FilterIndex = 1;
            opn.Multiselect = false;
            opn.RestoreDirectory = true;
            if (opn.ShowDialog() == DialogResult.OK)
            {
                var splashForm = new SplashScreenManager(OvnerForm, typeof(BekleForm), true, true);
                splashForm.ShowWaitForm();
                splashForm.SetWaitFormCaption("Lütfen Bekleyiniz!");
                splashForm.SetWaitFormDescription("Excell ortamından\nÖğrenci Bilgileri Alınıyor...");

                string _dosyaAdi = opn.FileName;
                _xlsUygulama = new Microsoft.Office.Interop.Excel.Application();
                _xlsKitap = _xlsUygulama.Workbooks.Open(_dosyaAdi);
                _xlsSayfa = _xlsKitap.Worksheets["Page 1"];
                _xlsHucre = _xlsSayfa.UsedRange;
                int i=0;
                for (xlsRow = 2; xlsRow < _xlsHucre.Rows.Count; xlsRow++)
                {
                    i++;
                    var row = new OgrenciBilgileriL
                    {
                        SinavKayitId = OvnerForm.Id,
                        OgrenciAdi = _xlsHucre.Cells[xlsRow, 4].Text.ToString(),
                        OgrenciNo = _xlsHucre.Cells[xlsRow, 2].Text.ToString(),
                        OgrenciBolum = _xlsHucre.Cells[xlsRow, 5].Text.ToString(),
                        OgrenciDers = _xlsHucre.Cells[xlsRow, 7].Text.ToString(),
                        Insert = true
                        };
                    source.Add(row);
                }
                _xlsKitap.Close();
                _xlsUygulama.Quit();
                splashForm.CloseWaitForm();

                tablo.Focus();
                tablo.RefreshDataSource();
                tablo.FocusedRowHandle = tablo.DataRowCount - 1;
                tablo.FocusedColumn = colOgrenciAdi;
                Cursor.Current = Cursors.Default;
                Kaydet();
                ButonenableDurumu(true);
            }

        }


    }
 
}
