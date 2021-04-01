using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
        public class Asiakas
    {
           
            public string EtuNimi { get; set; }
            public string SukuNimi { get; set; }
            public string Puhelin { get; set; }
            public string Sähköposti { get; set; }
            public string Osoite { get; set; }

            public void TulostaRuudulle()
            {
            Console.WriteLine(${"Etunimi = {EtuNimi},Sukunimi = {SukuNimi}, Puhelin = {Puhelin}, " +
                    "Sähköposti = {Sähköposti } ,Osoite = {Osoite}"};
            }
        }
    }
