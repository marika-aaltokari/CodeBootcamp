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
        public string AuthorNames { get; set; }
        public string AuthorSurname { get; set; }

        public string BookTitle { get; set; }

        public string Favorite { get; set; }

        [DataType(DataType.Date)]
        public DateTime SavingDate { get; set; }


    }

}
