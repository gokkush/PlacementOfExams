using DPU_Soft.PlacementOfExams.Data.PlacementOfExamsMiggration;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DPU_Soft.PlacementOfExams.Data.Contexts
{
    public class PlacementOfExamsContext : BaseDbContext<PlacementOfExamsContext,Configuration>
    {

        public PlacementOfExamsContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public PlacementOfExamsContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//gönderilen model isimleri sonuna s takýsý almadan aynen gider
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//baðlantýlý tablolarýn biri silinirse diðerinin de silinmesinin önüne geçer
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<IlEntity> Il { get; set; }
        public DbSet<IlceEntity> Ilce { get; set; }
        public DbSet<OkulEntity> Okul { get; set; }
        public DbSet<FiltreEntity> Filtre { get; set; }

        public DbSet<KullaniciEntity> Kullanici { get; set; }

        public DbSet<MailParametreEntity> MailParametre { get; set; }

        public DbSet<SubeEntity> Sube { get; set; }
        public DbSet<DonemEntity> Donem { get; set; }
        public DbSet<KullaniciBirimYetkileriEntity> KullaniciBirimYetkileri { get; set; }
    }


}