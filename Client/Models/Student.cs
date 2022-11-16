using System.ComponentModel.DataAnnotations;

namespace NWSInventaire.Client.Models
{
    public class Student
    {
        
        public int StudentId { get; set; }

        [MaxLength(50)]
        public string StudentName { get; set; }

        [MaxLength(50)]
        public string StudentMail { get; set; }


    }
}
