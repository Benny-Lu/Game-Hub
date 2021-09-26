using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Hub.Models
{
    public class Games
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Game_Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Initial Release")]
        public DateTime Initial_Release { get; set; }

        [Required]
        [StringLength(100)]
        public string Designer { get; set; }

        [Required]
        [StringLength(100)]
        public string Developer { get; set; }

        [Required]
        [StringLength(100)]
        public string Company { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        //One to many relationship
        public ICollection<Company> Companies { get; set; }
    }
}
