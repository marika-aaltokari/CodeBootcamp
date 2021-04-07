using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookshelf.Data;
using RazorPagesBookshelf.Models;

namespace RazorPagesBookshelf.Pages.Bookshelves
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesBookshelf.Data.RazorPagesBookshelfContext _context;

        public EditModel(RazorPagesBookshelf.Data.RazorPagesBookshelfContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bookshelf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookshelfExists(Bookshelf.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookshelfExists(int id)
        {
            return _context.Bookshelf.Any(e => e.ID == id);
        }
    }
}
