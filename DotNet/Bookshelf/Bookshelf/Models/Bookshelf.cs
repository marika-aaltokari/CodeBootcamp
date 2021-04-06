using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models
{
    public class BookshelfContext
    {
        public int ID { get; set; }
        public string AuthorNames { get; set; }
        public string AuthorSurame { get; set; }

        public string BookTitle { get; set; }

        public bool Favorite { get; set; }

        [DataType(DataType.Date)]
        public DateTime SavingDate { get; set; }
        
        public bool Read { get; set; }
    }
}
