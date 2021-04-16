using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AspNetMvcDemoMa.Models
{
    public class Book
    {

        public int ID { get; set; }
       // [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string AuthorNames { get; set; }
        //[RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string AuthorSurname { get; set; }

        public string Author => (string) AuthorNames + "," + AuthorSurname


       // [StringLength(60, MinimumLength = 3), Required]
        public string BookTitle { get; set; }

        public string Favorite { get; set; }


        //[Display(Name = "Saving Date"), DataType(DataType.Date)]
        public DateTime SavingDate { get; set; }
    }
}
