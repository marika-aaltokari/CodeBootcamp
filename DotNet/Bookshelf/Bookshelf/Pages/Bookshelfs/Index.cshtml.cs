using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bookshelf.Data;
using Bookshelf.Models;

namespace Bookshelf.Pages.Bookshelfs
{
    public class IndexModel : PageModel
    {
        private readonly Bookshelf.Data.BookshelfContext _context;

        public IndexModel(Bookshelf.Data.BookshelfContext context)
        {
            _context = context;
        }

        public IList<Data.BookshelfContext> Bookshelf { get;set; }

        public async Task OnGetAsync()
        {
            Bookshelf = (IList<Data.BookshelfContext>)await _context.Bookshelf.ToListAsync();
        }
    }
}
