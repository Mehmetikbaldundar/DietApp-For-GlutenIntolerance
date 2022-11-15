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
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.HasKey(x => x.UserID);
            this.Property(x => x.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.UserName).IsRequired().HasMaxLength(25);
            this.Property(x => x.Password).IsRequired();

            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();

            this.HasMany(g => g.MealReports)
                .WithRequired(s => s.User)
                .HasForeignKey(s => s.UserID);

            this.HasMany(g => g.Medicaments)
                .WithRequired(s => s.User)
                .HasForeignKey(s => s.UserID);

            this.HasOptional(s => s.BodyAnalysis)
                .WithRequired(x => x.User);                
                     
             this.HasRequired(s => s.UserDetails)
                .WithRequiredPrincipal(x => x.User);

            this.HasRequired(s => s.PhysicallyGoal)
                .WithRequiredPrincipal(x => x.User);

            this.HasOptional(s => s.Water)
                .WithRequired(x => x.User);
        }
    }
}
