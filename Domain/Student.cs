using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }

        [Required]
        public string studentName { get; set; }

        [Required]
        public string studentLastName { get; set; }

        [Required]
        public int studentCode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public string studentAddress { get; set; }

        public bool isActive { get; set; } = true;
    }
}
