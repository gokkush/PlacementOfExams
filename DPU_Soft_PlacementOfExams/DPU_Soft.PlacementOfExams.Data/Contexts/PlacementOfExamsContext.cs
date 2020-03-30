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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//g�nderilen model isimleri sonuna s tak�s� almadan aynen gider
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//ba�lant�l� tablolar�n biri silinirse di�erinin de silinmesinin �n�ne ge�er
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<IlEntity> Il { get; set; }
        public DbSet<IlceEntity> Ilce { get; set; }
        public DbSet<OkulEntity> Okul { get; set; }
    }


}