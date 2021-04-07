using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesBookshelf.Data;


namespace RazorPagesBookshelf.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesBookshelfContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesBookshelfContext>>()))
            {
                // Look for any books.
                if (context.Bookshelf.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bookshelf.AddRange(
                    new Bookshelf
                    {
                        AuthorNames= " Lotta",
                        AuthorSurname = "Dahl",
                        BookTitle = "Fadern",
                        SavingDate = DateTime.Parse("2021-7-4"),
                       
                    },

                    new Bookshelf
                    {
                        AuthorNames = " Lotta",
                        AuthorSurname = "Dahl",
                        BookTitle = "Fadern",
                        SavingDate = DateTime.Parse("2021-7-4"),

                    }, 
                
                    new Bookshelf
                    {
                        AuthorNames= " Karen",
                        AuthorSurname = "Collins",
                        BookTitle = "Närä till döden",
                        SavingDate = DateTime.Parse("2021-7-4"),
                    },
                        
                     new Bookshelf
                     {
                         AuthorNames = " Lucy",
                         AuthorSurname = "Foley",
                         BookTitle = "Jahti",
                         SavingDate = DateTime.Parse("2021-7-4"),
                        }
                    );
                    context.SaveChanges();
            }   
        }
    }
}


                   