using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Hub.Models
{
    public class Company
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Company_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Founded { get; set; }

        [Required]
        [StringLength(100)]
        public string Founder { get; set; }

        [Required]
        [StringLength(100)]
        public string Headquarters { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
