using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OfficeSeatBookingEntity
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        [Required]
        [MaxLength(25)]
        public string EmpEmail { get; set; }

        [Required]
        [MaxLength(12)]
        public string EmpPassword { get; set; }

        public double EmpPhone { get; set; }

        public char EmpGender { get; set; }

        public string EmpSecretKey { get; set; }

        public string EmpPlace { get; set; }

        /*public byte[] EmpPhoto { get; set; }*/

        public string EmpRole { get; set; }

        public string EmpDesignation { get; set; }
    }
}