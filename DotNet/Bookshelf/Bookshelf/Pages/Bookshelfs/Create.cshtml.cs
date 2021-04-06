using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bookshelf.Data;
using Bookshelf.Models;

namespace Bookshelf.Pages.Bookshelfs
{
    public class CreateModel : PageModel
    {
        private readonly Bookshelf.Data.BookshelfContext _context;

        public CreateModel(Bookshelf.Data.BookshelfContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        private Data.BookshelfContext bookshelfContext;

        public Data.BookshelfContext GetBookshelfContext()
        {
            return bookshelfContext;
        }

        public void SetBookshelfContext(Data.BookshelfContext value)
        {
            bookshelfContext = value;
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _ = _context.Bookshelf.Add(GetBookshelfContext());
            int v = await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
