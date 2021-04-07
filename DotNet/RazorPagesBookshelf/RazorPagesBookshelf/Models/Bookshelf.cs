using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesBookshelf.Models
{
    public class Bookshelf
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string AuthorNames { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string AuthorSurname { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string BookTitle { get; set; }

        public string Favorite { get; set; }

        [Display(Name = "Saving Date")]
        [DataType(DataType.Date)]
        public DateTime SavingDate { get; set; }

    }
}


       