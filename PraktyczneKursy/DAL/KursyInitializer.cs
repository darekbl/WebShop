using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PraktyczneKursy.Models;
using PraktyczneKursy.Migrations;
using System.Data.Entity.Migrations;

namespace PraktyczneKursy.DAL
{
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext,Configuration>
    {

        public static void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() { KategoriaId = 1, NazwaKategorii = "ASP", NazwaPlikuIkony = "aspnet.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId = 2, NazwaKategorii = "Java", NazwaPlikuIkony = "java.png", OpisKategorii="opis java"},
                new Kategoria() { KategoriaId = 3, NazwaKategorii = "Php", NazwaPlikuIkony = "php.png", OpisKategorii="opis php"},
                new Kategoria() { KategoriaId = 4, NazwaKategorii = "Html", NazwaPlikuIkony = "html.png", OpisKategorii="opis html"},
                new Kategoria() { KategoriaId = 5, NazwaKategorii = "CSS", NazwaPlikuIkony = "css.png", OpisKategorii="opis css"},
                new Kategoria() { KategoriaId = 6, NazwaKategorii = "Xml", NazwaPlikuIkony = "xml.png", OpisKategorii="opis xml"},
                new Kategoria() { KategoriaId = 7, NazwaKategorii = "C#", NazwaPlikuIkony = "csharp.png", OpisKategorii="opis c#"},
            };
                kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs() { KursId = 1, AutorKursu = "Darek", TytulKursu = "asp.net mvc", KategoriaId = 1, CenaKursu = 99, Bestseller = true, NazwaPlikuObrazka = "obrazekaspnet.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 1."},
                new Kurs() { KursId = 2, AutorKursu = "Radek", TytulKursu = "Php dla zielonych", KategoriaId = 3, CenaKursu = 65, Bestseller = false, NazwaPlikuObrazka = "obrazekphp.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 2."},
                new Kurs() { KursId = 3, AutorKursu = "Stefan", TytulKursu = "Html dla równie zielonych", KategoriaId = 4, CenaKursu = 115, Bestseller = true, NazwaPlikuObrazka = "obrazekhtml.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 3."},
                new Kurs() { KursId = 4, AutorKursu = "Kacper", TytulKursu = "CSS First", KategoriaId = 5, CenaKursu = 98, Bestseller = false, NazwaPlikuObrazka = "obrazekcss.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 4."},
                new Kurs() { KursId = 5, AutorKursu = "Leon", TytulKursu = "XML ? Co to!", KategoriaId = 6, CenaKursu = 190, Bestseller = true, NazwaPlikuObrazka = "obrazekxml.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 5."},
                new Kurs() { KursId = 6, AutorKursu = "Mietek", TytulKursu = "Si Szarp 4 U", KategoriaId = 7, CenaKursu = 220, Bestseller = true, NazwaPlikuObrazka = "obrazekcsharp.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 6."},
                new Kurs() { KursId = 7, AutorKursu = "Józef", TytulKursu = "Jaaaava", KategoriaId = 2, CenaKursu = 295, Bestseller = true, NazwaPlikuObrazka = "obrazekphp.png", DataDodania = DateTime.Now, OpisKursu = "Opis kursu 7."}
            };

            kursy.ForEach(k => context.Kursy.AddOrUpdate(k));
            context.SaveChanges();

            }
        }
    }