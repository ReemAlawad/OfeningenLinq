using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BierenLibrary;

namespace Bieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BierenService service = new BierenService();
            //Console.WindowWidth = 100;
            //Console.WriteLine("{0,-20}{1,-100}{2,-20}{3,-20}", "Nummer", "Naam", "Alcohol", "Brouwer");
            //foreach (Bier bier in service.Bieren)
            //{
            //    Console.WriteLine("{0,-20}{1,-100}{2,-20}{3,-20}", bier.BierNr, bier.Naam, bier.Alcohol, bier.Brouwer);
            //}
            //  List<Bier> bieren = new List<Bier>();
            // List<Bier> bierenVanJupiler1 = service.Bieren.Where(m => m.Brouwer.ToLower() == "Jupiler").ToList();
            //List<Bier> bierenVanJupiler = (from bier in service.Bieren
            //                               where bier.Brouwer.ToLower() == "Jupiler"
            //                               select bier).ToList();
            //foreach (var item in bierenVanJupiler1)
            //{
            //    Console.WriteLine(item.Naam + item.Brouwer);
            //}

            //Method chaining
            //List<Bier> bierenVanJupiler1 = service.Bieren.Where(m => m.Brouwer.ToLower() == "jupiler").ToList();

            //foreach (var item in bierenVanJupiler1)
            //{
            //    Console.WriteLine(item.Naam + item.Brouwer);
            //}

            //  Console.WriteLine(bierenVanJupiler.ToString());

            var bierMeerDan = service.Bieren.Where(b => b.Alcohol > 7).ToList();
            foreach (var item in bierMeerDan)
            {
                Console.WriteLine($"{item.Alcohol}: {item.Naam}");
            }

            //var alleBierenMetDelhaize = service.Bieren.Where(n => n.Brouwer == "Roman").ToList();
            //foreach (var item in alleBierenMetDelhaize)
            //{
            //    Console.WriteLine(item.Brouwer.ToString());
            //}
            //  Console.WriteLine(alleBierenMetDelhaize.ToList());

            //var bierMetNr120 = service.Bieren.Where(b => b.BierNr == 120);
            //foreach (var item in bierMetNr120)
            //{
            //    Console.WriteLine(item.Naam + item.Brouwer + item.BierNr);
            //}

            //var brouwerJupiler = service.Bieren.Where(b => b.Brouwer == "jupiler" && b.Alcohol <= 5).ToList();
            //foreach (var item in brouwerJupiler)
            //{
            //    Console.WriteLine(item.Naam);
            //}

            // var brouwerJupilerPalmArtois = service.Bieren.Where(b => b.)

            //var brouwerGemiddeld = from p in service.Bieren
            //                       group p by p.Alcohol
            //                       into pGroup
            //                       select new
            //                       {
            //                           AlleBrouwers = pGroup.Key,
            //                           AverageAlcohol = pGroup.Average(x => x.Alcohol)
            //                       };
            //foreach (var item in brouwerGemiddeld)
            //{
            //    Console.WriteLine(item.AlleBrouwers + " " + item.AverageAlcohol);
            //}

            //Avarage per category
            //var CategoryAverageScores = from p in getAll
            //                            group p by p.Category
            //                            into pGroup
            //                            select new
            //                            {
            //                                Category = pGroup.Key,
            //                                AveragePrice = pGroup.Average(x => x.Price)
            //                            };
            //foreach (var item in CategoryAverageScores)
            //{
            //    Console.WriteLine(item.Category + " "+ item.AveragePrice.ToString("c"));
            //}

        }
       
    }
}
