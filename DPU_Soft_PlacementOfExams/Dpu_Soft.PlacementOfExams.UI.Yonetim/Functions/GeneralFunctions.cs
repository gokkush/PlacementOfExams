using DevExpress.XtraSplashScreen;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.UI.Yonetim.Forms.Genelforms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Yonetim.Functions
{
    public class GeneralFunctions
    {
        protected internal static bool CreateDatabase<TContext>(string splashCaption, string splashDescription, string onayMesaj, string bilgiMesaj) where TContext : DbContext, new()
        {
            using (var con = new TContext())
            {
                con.Database.Connection.ConnectionString = BLL.Functions.GeneralFunctions.GetConnectionString();
                if (con.Database.Exists()) return true;

                if (Messages.EvetSeciliEvetHayir(onayMesaj, "Onay") != DialogResult.Yes) return false;
                var splashForm = new SplashScreenManager(Form.ActiveForm,typeof(BekleForm),true,true);
                SplashBaslat(splashForm);
                splashForm.SetWaitFormCaption(splashCaption);
                splashForm.SetWaitFormDescription(splashDescription);


                try
                {
                    if (con.Database.CreateIfNotExists())
                    {
                        SplashDurdur(splashForm);
                        Messages.UyariMesaji(bilgiMesaj);
                        return true;
                    }
                }
                catch (SqlException ex)
                {

                    SplashDurdur(splashForm);
                    switch (ex.Number)
                    {
                        case 5170:
                            Messages.HataMesaji("Veri Tabanı dosyalarının yükleneceği klasörde aynı isimde zaten bir dosya var. Lütfen Kontrol Ediniz \n\n"+ex.Message);
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }
                return false;
            }
        }
        private static void SplashBaslat(SplashScreenManager splManeger)
        {

            if (splManeger.IsSplashFormVisible)
            {
                splManeger.CloseWaitForm();
                splManeger.ShowWaitForm();
            }

            else
                splManeger.ShowWaitForm();

        }

        private static void SplashDurdur(SplashScreenManager splManeger)
        {
            if (splManeger.IsSplashFormVisible)
            {
                splManeger.CloseWaitForm();
            }

        }

        protected internal static bool DeleteDatabase<TContext>() where TContext:DbContext, new()
        {
            using (var con= new TContext())
            {
                con.Database.Connection.ConnectionString = BLL.Functions.GeneralFunctions.GetConnectionString();

                if (Messages.HayirSeciliEvetHayir("Seçtiğiniz Üniversite ve Üniversite İşlemlerinin Tamamını içeren Veri Tabanı Silinecektir. Onaylıyor musunuz?", "Silme Onayı") != DialogResult.Yes) return false;
                if (Messages.HayirSeciliEvetHayir("Veri Tabanı Silinmesine Kesin Emin misiniz(İşlem Geri Döndürülemeyecektir.)", "Silme Onayı") != DialogResult.Yes) return false;

                try
                {
                    if (con.Database.Delete())
                    {
                        Messages.UyariMesaji("Üniversite Silme İşlemi Başarılı Bir Şekilde Tamamlanmıştır. ");
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 3702:
                            Messages.HataMesaji("Veri Tabanı halen kullanımda olduğu için silinemedi. Veri Tabanına yapılan tüm bağlantıları sonlandırınız.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                     
                    }
                }

                return false;
            }
        }

    }
}
