
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookshelf.Models;

namespace RazorPagesBookshelf.Pages.Bookshelves
{
    #region snippet1
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBookshelf.Data.RazorPagesBookshelfContext _context;

        public IndexModel(RazorPagesBookshelf.Data.RazorPagesBookshelfContext context)
        {
            _context = context;
        }
        #endregion
        public IList<Bookshelf> Bookshelf { get;set; }

        public async Task OnGetAsync()
        {
            Bookshelf = await _context.Bookshelf.ToListAsync();
        }
    }
}
