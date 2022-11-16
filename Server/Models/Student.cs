using System.ComponentModel.DataAnnotations;

namespace NWSInventaire.Server.Models
{
    public class Student
    {
        
        public int StudentId { get; set; }

        [MaxLength(50)]
        [Required]
        public string? StudentName { get; set; }

        [MaxLength(50)]
        [Required]
        public string? StudentMail { get; set; }


    }
}
