using DPU_Soft.PlacementOfExams.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Data.PlacementOfExamsYonetimMiggration
{
    public class Configuration : DbMigrationsConfiguration<PlacementOfExamsYonetimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
