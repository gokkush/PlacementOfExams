using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Configuration;
using System.Security;
using System.Data.SqlClient;
using DPU_Soft.PlacementOfExams.UI.Win.Properties;
using DPU_Soft.BLL.Functions;
using System.Security.Cryptography;
using System.Text;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System.Net.Mail;
using System.Net;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DevExpress.XtraLayout;

namespace DPU_Soft.PlacementOfExams.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle>-1)
            {
                return  (long)tablo.GetFocusedRowCellValue("Id");
            }
            Messages.KartSecmemeHataMesaj();
            return -1;
        }

        public static void ShowGridPreview(this GridControl grid)
        {
            if (!grid.IsPrintingAvailable)
            {
                Messages.HataMesaji("Yazdırma Ekranı Açılamadı");
                return;
            }
            
            grid.ShowPrintPreview();
        }


        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle>-1)
            {
                return (T)tablo.GetRow(tablo.FocusedRowHandle);
            }
            if (mesajVer)
            {
                Messages.KartSecmemeHataMesaj();
            }
            return default(T);
        }

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1)
                return (T)tablo.GetRow(rowHandle);
              //  Messages.KartSecmemeHataMesaj();

            return default(T);
        }

        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {

                foreach (var prop in currentEntity.GetType().GetProperties())
                {
                    if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                    var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                    var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                    if (prop.PropertyType == typeof(byte[]))
                    {
                        if (string.IsNullOrEmpty(oldValue.ToString())) oldValue = new byte[] { 0 };
                        if (string.IsNullOrEmpty(currentValue.ToString())) currentValue = new byte[] { 0 };
                        if ((((byte[])oldValue).Length != (((byte[])currentValue).Length)))
                        {
                        return VeriDegisimYeri.Alan;
                        }
                    }
                if (prop.PropertyType == typeof(SecureString))
                {
                    var oldStr = ((SecureString)oldValue).ConvertToUnSecureString();
                    var curStr = ((SecureString)currentValue).ConvertToUnSecureString();
                    if (!oldStr.Equals(curStr))
                        return VeriDegisimYeri.Alan;
                }
                else if (!currentValue.Equals(oldValue))
                    {
                    return VeriDegisimYeri.Alan;
                    }
                }
            return VeriDegisimYeri.VeriDegisimiYok;
            
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity) 
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabeledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabeledDurumu;
            btnGeriAl.Enabled = buttonEnabeledDurumu;
            btnYeni.Enabled = !buttonEnabeledDurumu;
            btnSil.Enabled = !buttonEnabeledDurumu;
        }
        public static void ButtonEnabledDurumu(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil)
        {
            btnKaydet.Enabled = false;
            btnGeriAl.Enabled = false;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity,bool tableValueChanged)
        {
            var veriDegisimYeri = tableValueChanged?VeriDegisimYeri.Tablo: VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabeledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan|| veriDegisimYeri==VeriDegisimYeri.Tablo;

            btnKaydet.Enabled = buttonEnabeledDurumu;
            btnGeriAl.Enabled = buttonEnabeledDurumu;
            btnYeni.Enabled = !buttonEnabeledDurumu;
            btnSil.Enabled = !buttonEnabeledDurumu;
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet,BarButtonItem btnFarkliKaydet, BarButtonItem btnSil,IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var buttonEnabeledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabeledDurumu;
            btnFarkliKaydet.Enabled = islemTuru!=IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnabeledDurumu;
        }
        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            string SifirEkle(string deger)
            {
                if (deger.Length==1)
                {
                    return "0" + deger;
                }
                return deger;
            }
            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;

                }
                return deger;
            }
            string Id()
            {
                var yil = SifirEkle(DateTime.Now.Year.ToString());
                var ay = SifirEkle(DateTime.Now.Month.ToString());
                var gun = SifirEkle(DateTime.Now.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Second.ToString());
                var miliSaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var randomSayi = SifirEkle(new Random().Next(0,99).ToString());
                return yil + ay + gun + saat + dakika + saniye + miliSaniye + randomSayi;
            }
            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());

        }

        public static void ControlEnabledChange(this DpuButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case DpuButtonEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue&&baseEdit.Id>0;
                   // edt.Id = null;
                    edt.EditValue = null;
                    break;

            }
        }

        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            var rowHandle = 0;
            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i,aranacakKolon);
                if (aranacakDeger.Equals(bulunanDeger)) rowHandle = i;
                
            }
            tablo.FocusedRowHandle = rowHandle;
        }

        public static void RowFocus(this GridView tablo, int rowhandle)
        {
            if (rowhandle <= 0) return;
            if (rowhandle == tablo.RowCount - 1)
                tablo.FocusedRowHandle = rowhandle;
            else
                tablo.FocusedRowHandle = rowhandle - 1;
            
        }

        public static void SagMenuGoster(this MouseEventArgs e,PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);
            
        }

        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void AppSettingsWrite(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void CreateConnectionString(string initialCatalog, string server,SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru)
        {
            SqlConnectionStringBuilder builder = null;

            switch (yetkilendirmeTuru)
            {
                case YetkilendirmeTuru.SqlServer:
                    builder = new SqlConnectionStringBuilder
                    {
                        
                        DataSource = server,
                        UserID = kullaniciAdi.ConvertToUnSecureString(),
                        Password=sifre.ConvertToUnSecureString(),
                        InitialCatalog = initialCatalog,
                        MultipleActiveResultSets = true

                    };
                    break;
                case YetkilendirmeTuru.Windows:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        IntegratedSecurity = true,
                        InitialCatalog = initialCatalog,
                        MultipleActiveResultSets = true
                    };
                    break;
            }
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["PlacementOfExamsContext"].ConnectionString = builder?.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            Settings.Default.Reset();
            Settings.Default.Save();
        }



        public static bool BaglantiKontrolu(string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru, bool genelMesajVer= false)
        {
            CreateConnectionString("", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var con= new SqlConnection(BLL.Functions.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (con.ConnectionString == "") 
                        return false;
                    con.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (genelMesajVer)
                    {
                        Messages.HataMesaji("Bağlantı ayarlarınız hatalıdır. Lütfen Kontrol ediniz.");
                        return false;
                    }

                    switch (ex.Number)
                    {
                        case 18456:
                            Messages.HataMesaji("Server kullanıcı adı veya şifre hatalıdır.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }
                return false;
            }
        }

        public static string md5Sifrele(this string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var byt = Encoding.UTF8.GetBytes(value);
            byt = md5.ComputeHash(byt);
            var md5Sifre = BitConverter.ToString(byt).Replace("-","");
            return md5Sifre;
        }
        public static (SecureString secureSifre, SecureString secureGizliKelime, string sifre, string gizliKelime) SifreUret()
        {
            string RandomDegerUret(int minValue, int count)
            {
                var random = new Random();
                const string karakterTablosu = "0123456789ABCDEFGHIJKLMNOPQRSTUWXVYZabcdefghijklmnopqrsdtuwxvz";
                string sonuc = null;
                for (int i = 0; i < count; i++)
                    sonuc += karakterTablosu[random.Next(minValue, karakterTablosu.Length - 1)].ToString() ;
                return sonuc;
            }

            var secureSifre = RandomDegerUret(0,8).ConvertToSecureString();
            var secureGizliKelime = RandomDegerUret(9, 10).ConvertToSecureString();
            var sifre = secureSifre.ConvertToUnSecureString().md5Sifrele();
            var gizliKelime = secureGizliKelime.ConvertToUnSecureString().md5Sifrele();
            return (secureSifre, secureGizliKelime, sifre, gizliKelime); 
        }

        public static bool SifreMailiGonder(this string kullaniciAdi, string eMail, SecureString secureSifre, SecureString secureGizlikKelime)
        {
            using (var bll=new MailParametreBll())
            {
                var entity = (MailParametreEntity)bll.Single(null);
                if (entity==null)
                {
                    Messages.HataMesaji("E-mail gönderilemedi. Fakültenin e-mail parametreleri girilmemniş. Lütfen kontrol ediniz.");
                    return false;
                }
                var client = new SmtpClient
                {
                    Port = entity.PortNo,
                    Host=entity.Host,
                    EnableSsl=entity.SslKullan==EvetHayir.Evet,
                    UseDefaultCredentials=true,
                    Credentials=new NetworkCredential(entity.Email,entity.Sifre.Decrypt(entity.Id+entity.Kod).ConvertToSecureString())

                };

                var mesaj = new MailMessage
                {
                    From = new MailAddress(entity.Email, "DPU_Soft PlacementOfExams"),
                    To = { eMail },
                    Subject = "PlacementOfExams Kullanıcı Bilgileri",
                    IsBodyHtml = true,
                    Body = "PlacementOfExams Programı için gereken Kullanıcı Adı, Şifre ve Gizli Kelime Bilgileri aşağıda belirtilmiştir.<br/>" +
                            "Lütfen programa giriş yaptıkran sonra bu bilgileri değiştiriniz!<br/><br/><br/>" +
                            $"<b>Kullanıcı Adı:</b> {kullaniciAdi}<br/>" +
                            $"<b>Şifre        :</b> {secureSifre.ConvertToUnSecureString()}<br/>" +
                            $"<b>Gizli Kelime :</b> {secureGizlikKelime.ConvertToUnSecureString()}<br/>"

                };

                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    client.Send(mesaj);

                    Cursor.Current = Cursors.Default;
                    return true;
                }
                catch (Exception ex)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
            }
        }

        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();

            if (!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter-= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);
            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;
                if (!entity.Delete) return;
                e.Visible = false;
                e.Handled = true;
            }
        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity>list)
        {
            return new BindingList<T>((IList<T>)list);
        }

        public static void EncryptConfigFile(string configFileName, params string[] prm)
        {
            var configration = ConfigurationManager.OpenExeConfiguration(configFileName);
            foreach (var x in prm)
            {
                var section = configration.GetSection(x);
                if (section.SectionInformation.IsProtected) return;
                else
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

                section.SectionInformation.ForceSave = true;
                configration.Save();

            }
        }

        public static BaseTablo AddTable(this BaseTablo tablo, BaseEditForm frm)
        {
            tablo.Dock = DockStyle.Fill;
            tablo.OvnerForm = frm;
            return tablo;
        }

        public static void LayoutControlInsert(this LayoutGroup grup, Control ctrl, int columnIndex, int rowIndex, int columnSpan, int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control = ctrl,
                Parent = grup
            };
            item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
            item.OptionsTableLayoutItem.RowIndex = rowIndex;
            item.OptionsTableLayoutItem.ColumnSpan = columnSpan;
            item.OptionsTableLayoutItem.RowSpan = rowSpan;
        }
    }
}
