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

            this.HasRequired(s => s.BodyAnalysis)
                .WithRequiredPrincipal(s => s.User);

            this.HasMany(g => g.MealReports)
                .WithRequired(s => s.User)
                .HasForeignKey(s => s.UserID);

            this.HasMany(g => g.Medicaments)
                .WithRequired(s => s.User)
                .HasForeignKey(s => s.UserID);

            this.HasRequired(s => s.UserDetails)
                .WithRequiredPrincipal(s => s.User);

            this.HasRequired(s => s.PhysicallyGoal)
                .WithRequiredPrincipal(s => s.User);

<<<<<<< HEAD
            this.HasRequired(s => s.Water)
                .WithRequiredPrincipal(s => s.User);
=======
            this.HasMany(s => s.Water)
                .WithRequired(s => s.User)
                .HasForeignKey(s => s.UserID);
>>>>>>> master

        }
    }
}
