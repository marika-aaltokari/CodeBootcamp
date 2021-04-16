using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsNetWebApiDemoMa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookApiController : ControllerBase
    {

        
        [HttpGet]
        [Route("kaikki")]
        public List<Book> PalautaKaikki()
        {
            BookshelfContext konteksti = new();
            List<Book> kirjat = konteksti.Books.ToList();
            return kirjat;
        }


        [HttpGet]
        [Route("search/{krjanNimi}")]
        public List<Book> PalautaNimenMukaan(string kirjanNimi)
        {
            BookshelfContext konteksti = new();
            List<Book> haettu1 = konteksti.Books.
                Where(t => t.BookTitle == kirjanNimi).ToList();
            return haettu1;
        }

        [HttpGet]
        [Route("search/{kirjailijanNimi}")]
        public List<Book> PalautaTekijänMukaan(string )
        {
            BookshelfContext konteksti = new();
            List<Book> haettu2 = konteksti.Books.
                Where(a => a. Author == ¨kirjailijanNimi).ToList();
            return haettu2;
        }


        [HttpPost]
        [Route("")]
        public void LisääUusi([FromBody] Book uusiKirja)
        {
            BookshelfContext konteksti = new();
            konteksti.Books.Add(uusiKirja);
            konteksti.SaveChanges();
        }
    }
}
