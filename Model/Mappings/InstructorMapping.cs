using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    public class InstructorMapping : EntityTypeConfiguration<Instructor>
    {
        public InstructorMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName);
            Property(x => x.LastName);

            HasRequired(x => x.Department).WithMany(y => y.DepartmentStaff).HasForeignKey(x => x.Department_Id).WillCascadeOnDelete(false);

            ToTable("Instructors");
        }
    }
}
