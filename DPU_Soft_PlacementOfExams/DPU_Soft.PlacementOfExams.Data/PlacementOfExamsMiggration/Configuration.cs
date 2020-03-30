using DPU_Soft.PlacementOfExams.Data.Contexts;
using System.Data.Entity.Migrations;

namespace DPU_Soft.PlacementOfExams.Data.PlacementOfExamsMiggration
{
    public class Configuration:DbMigrationsConfiguration<PlacementOfExamsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
