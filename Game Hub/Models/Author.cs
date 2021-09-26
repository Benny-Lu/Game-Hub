using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Hub.Models
{
    public class Author
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [Required]
        [Display(Name="Phone Number")]
        public int Phone_Number { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Account Made")]
        public DateTime AccountMade { get; set; }

        //One to many 
        public ICollection<Games> Games { get; set; }
    }
}
