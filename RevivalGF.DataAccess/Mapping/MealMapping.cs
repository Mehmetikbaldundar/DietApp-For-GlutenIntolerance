using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.DataAccess.Mapping
{
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            this.HasKey(x => x.MealID);
            this.Property(x => x.MealID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.MealName).HasMaxLength(50).IsRequired();
            this.Property(x => x.Recipe).IsOptional();
            this.Property(x => x.Calorie).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.Carbonhydrade).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.Fat).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.Protein).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.Gram).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.AlternativeFoodID).IsOptional();

            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();

            this.HasMany(p => p.AlternativeFoods)
                .WithOptional(p => p.RiskyFoods)
                .HasForeignKey(p => p.AlternativeFoodID)
                .WillCascadeOnDelete(false);

            this.HasMany(s => s.MealReports)
                .WithMany(c => c.Meals)
                .Map(cs =>
                {
                    cs.MapLeftKey("MealRefID");
                    cs.MapRightKey("MealReportRefID");
                    cs.ToTable("Reports");
                });

        }
    }
}
