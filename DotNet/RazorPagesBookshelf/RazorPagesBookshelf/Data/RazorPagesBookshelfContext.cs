using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookshelf.Models;
using Microsoft.EntityFrameworkCore;


namespace RazorPagesBookshelf.Data
{
    public class RazorPagesBookshelfContext : DbContext
    {
        public RazorPagesBookshelfContext (DbContextOptions<RazorPagesBookshelfContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBookshelf.Models.Bookshelf> Bookshelf { get; set; }
    }
}
