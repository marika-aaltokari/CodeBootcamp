using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookshelf.Models;

namespace Bookshelf.Data
{
    public class BookshelfContext : DbContext
    {
        public BookshelfContext (DbContextOptions<BookshelfContext> options)
            : base(options)
        {
        }

        public DbSet<Bookshelf.Models.BookshelfContext> Bookshelf { get; set; }

        public static implicit operator BookshelfContext(Models.BookshelfContext v)
        {
            throw new NotImplementedException();
        }
    }
}
