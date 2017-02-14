using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Instructor : Entity
    {

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        public Guid Department_Id { get; set; }

        
        [ForeignKey("Department_Id")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Student> AdvisingStudents { get; set; }
        
    }
}
