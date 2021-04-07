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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesBookshelf.Data.RazorPagesBookshelfContext _context;

        public DeleteModel(RazorPagesBookshelf.Data.RazorPagesBookshelfContext context)
        {
            _context = context;
        }

        [BindProperty]
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
