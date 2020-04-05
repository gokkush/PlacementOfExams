using System.Windows.Forms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Dto;
using System.IO;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Data.OleDb;
using System.Globalization;
using System.Data;

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
            OpenFileDialog opn = new OpenFileDialog();
            opn.Title = "Lütfen Dosya Seçiniz";
            opn.Filter = " (*.xlsx)|*.xlsx";
            opn.FilterIndex = 1;
            opn.Multiselect = false;
            opn.RestoreDirectory=true;
            if (opn.ShowDialog() == DialogResult.OK)
            {
                string filePath = opn.FileName;
                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader;
                System.Windows.Forms.ListBox lst = new System.Windows.Forms.ListBox();
                //Gönderdiğim dosya xls'mi xlsx formatında mı kontrol ediliyor.
                if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                {
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else
                {
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                while (excelReader.Read())
                {
                    lst.Items.Add(excelReader.GetString(1));
                }

                excelReader.Close();
                foreach (var item in lst.Items)
                {
                    MessageBox.Show(item.ToString());
                }
            }

            //var source = tablo.DataController.ListSource;
            //ListeDisiTutulacakKayitlar = source.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).Select(x => x.SinavSalonu_Id).ToList();

            //var entities = ShowListforms<SinavSalonuListForm>.ShowDialogListForm(KartTuru.SinavSalonBilgiKayit, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<SinavSalonuEntity>();
            //if (entities == null) return;

            //foreach (var entity in entities)
            //{
            //    var row = new SinavSalonBilgileriL
            //    {
            //        SalonAdi = entity.SalonAdi,
            //        SinavKayitId = OvnerForm.Id,
            //        SinavSalonu_Id = entity.Id,
            //        SalonKapasitesi = entity.SalonKapasitesi,
            //        GozetmenSayisi = entity.GozetmenSayisi,

            //        Insert = true
            //    };

            //    source.Add(row);
            //}
            tablo.Focus();
                tablo.RefreshDataSource();
                tablo.FocusedRowHandle = tablo.DataRowCount - 1;
                tablo.FocusedColumn = colOgrenciAdi;

                ButonenableDurumu(true);
            }

        }

    
}
