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
    public class WaterMapping : EntityTypeConfiguration<Water>
    {
        public WaterMapping()
        {
            this.HasKey(x => x.WaterID);
            this.Property(x => x.WaterID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.WaterCount).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.ReportDate).IsRequired();

            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();
        }
    }
}
