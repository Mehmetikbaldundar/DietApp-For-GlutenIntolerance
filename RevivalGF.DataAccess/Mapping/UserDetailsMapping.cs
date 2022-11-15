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
    public class UserDetailsMapping : EntityTypeConfiguration<UserDetails>
    {
        public UserDetailsMapping()
        {
            this.HasKey(x => x.DetailsID);
            this.Property(x => x.DetailsID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Email).IsRequired().HasMaxLength(50);
            this.Property(x => x.Name).IsRequired().HasMaxLength(25);
            this.Property(x => x.Surname).IsRequired().HasMaxLength(25);
            this.Property(x => x.Gender).IsRequired();
            this.Property(x => x.Height).IsRequired();
            this.Property(x => x.Weight).IsRequired();
            this.Property(x => x.GlutenIntolerance).IsRequired();
            this.Property(x => x.BirthDate).IsRequired();

            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();

            
        }
    }
}
