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
    public class PhysicallyGoalMapping : EntityTypeConfiguration<PhysicallyGoal>
    {
        public PhysicallyGoalMapping()
        {
            this.HasKey(x => x.GoalID);
            this.Property(x => x.GoalID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.TargetedDiet).IsRequired();
            this.Property(x => x.ActivityStatus).IsRequired();

            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);

            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();
        }
    }
}
