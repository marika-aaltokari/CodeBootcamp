
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookshelf.Models;
using System.Linq;

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
        public IList<Bookshelf> Bookshelf { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Favorites { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookshelfFavorite { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Bookshelf
                                            orderby m.Favorite
                                            select m.Favorite;

            var bookshelves = from m in _context.Bookshelf
                              select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                bookshelves = bookshelves.Where(s => s.BookTitle.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(BookshelfFavorite))
            {
                bookshelves = bookshelves.Where(x => x.Favorite == BookshelfFavorite);
            }
            Favorites = new SelectList(await genreQuery.Distinct().ToListAsync());
            Bookshelf = await bookshelves.ToListAsync();
        }
    }
  }


