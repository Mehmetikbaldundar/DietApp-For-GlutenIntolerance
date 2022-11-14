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
    public class MedicamentMapping : EntityTypeConfiguration<Medicament>
    {
        public MedicamentMapping()
        {
            this.HasKey(x => x.MedicamentID);
            this.Property(x => x.MedicamentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.MedicamentName).IsRequired().HasMaxLength(50);
            this.Property(x => x.HourOfUsage).IsRequired();
            this.Property(x => x.TotalUsage).IsRequired();

            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();
        }
    }
}
