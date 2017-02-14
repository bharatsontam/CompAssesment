using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Department : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(4, ErrorMessage ="Please specify only four characters of Department Code")]
        public string Moniker { get; set; }
        
        public Guid HeadOfDepartment_Id { get; set; }

        [ForeignKey("HeadOfDepartment_Id")]
        public virtual Instructor HeadOfDepartment { get; set; }


        public virtual ICollection<Instructor> DepartmentStaff { get; set; }
    }
}
