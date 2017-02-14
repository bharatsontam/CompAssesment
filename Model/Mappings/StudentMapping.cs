using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName);
            Property(x => x.LastName);

            HasRequired(x => x.Advisor).WithMany(i => i.AdvisingStudents).HasForeignKey(f => f.Advisor_Id).WillCascadeOnDelete(false);

            ToTable("Students");
        }
    }
}
