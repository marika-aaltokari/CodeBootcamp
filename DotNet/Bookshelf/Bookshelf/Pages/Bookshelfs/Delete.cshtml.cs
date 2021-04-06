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
    public class DeleteModel : PageModel
    {
        private readonly Bookshelf.Data.BookshelfContext _context;

        public DeleteModel(Bookshelf.Data.BookshelfContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Data.BookshelfContext Bookshelf { get; set; }

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bookshelf = await _context.Bookshelf.FindAsync(id);

            if (Bookshelf != null)
            {
                _context.Bookshelf.Remove(Bookshelf);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
