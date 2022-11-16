using RevivalGF.DataAccess.Mapping;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.DataAccess.Context
{
    public class RevivalGfDbContext : DbContext
    {
        public RevivalGfDbContext() : base("Server=DESKTOP-ORUQO20;Database=NRM1_DIET;Trusted_Connection=True;") //- DB LOKASYON -
        {
            // "Server=DESKTOP-IKBAL\\MSSQLSERVER2019;Database=NRM1-RevivalGfDb;Trusted_Connection=True;" --- İKBAL
            // "Server=DESKTOP-ORUQO20;Database=NRM1_DIET2;Trusted_Connection=True;" --- AYŞENUR
            Database.SetInitializer(new CreateDatabaseIfNotExists<RevivalGfDbContext>()); // Default
            
                    
        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<BodyAnalysis> BodyAnalyses { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealReport> MealReports { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PhysicallyGoal> PhysicallyGoals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Water> Waters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ActivityMapping());
            modelBuilder.Configurations.Add(new BodyAnalysisMapping());
            modelBuilder.Configurations.Add(new MealMapping());
            modelBuilder.Configurations.Add(new MealReportsMapping());
            modelBuilder.Configurations.Add(new MedicamentMapping());
            modelBuilder.Configurations.Add(new PhysicallyGoalMapping());
            modelBuilder.Configurations.Add(new UserDetailsMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new WaterMapping());
        }



    }
}
