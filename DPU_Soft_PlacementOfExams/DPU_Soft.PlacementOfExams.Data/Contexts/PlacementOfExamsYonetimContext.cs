
using DPU_Soft.PlacementOfExams.Data.PlacementOfExamsYonetimMiggration;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DPU_Soft.PlacementOfExams.Data.Contexts
{
    public class PlacementOfExamsYonetimContext : BaseDbContext<PlacementOfExamsYonetimContext, Configuration>
    {
        public PlacementOfExamsYonetimContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public PlacementOfExamsYonetimContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//gönderilen model isimleri sonuna s takısı almadan aynen gider
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//bağlantılı tabloların biri silinirse diğerinin de silinmesinin önüne geçer
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<KurumEntity> Kurum { get; set; }
    }
}
