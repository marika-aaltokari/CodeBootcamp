using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookshelf.Data;
using RazorPagesBookshelf.Models;

namespace RazorPagesBookshelf.Pages.Bookshelves
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesBookshelf.Data.RazorPagesBookshelfContext _context;

        public DetailsModel(RazorPagesBookshelf.Data.RazorPagesBookshelfContext context)
        {
            _context = context;
        }

        public Bookshelf Bookshelf { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bookshelf = await _context.Bookshelf.FirstOrDefaultAsync(m => m.ID == id);

            if (Bookshelf == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
