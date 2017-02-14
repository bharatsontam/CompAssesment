using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : Entity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        [Display(Name ="Advisor")]
        [ForeignKey("Advisor")]
        public Guid Advisor_Id { get; set; }

        
        public virtual Instructor Advisor { get; set; }

    }
}
