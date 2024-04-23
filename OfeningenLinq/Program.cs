using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfeningenLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vrag1
            Console.WriteLine("Vraag 1");
            List<int> getallen = new List<int>() {1,2,5,8,4,88,35,72,100 };
            var GrootGetal = getallen.Where(s => s > 10);
            foreach (var item in GrootGetal)
            {
                Console.WriteLine(item);
            }
            //vraag2
            Console.WriteLine("Vraag 2");
            var EvenGetallen = getallen.Where(s => s %2 == 0);
            foreach (var item in EvenGetallen)
            {
                Console.WriteLine(item);
            }
            // vraag 3
            Console.WriteLine("Vraag 3");
            List<string> Namen = new List<string>() {"Ahmed","Reem","Ghazal","Ahlam","Rik" };
            var NamenZoken = Namen.Where(s => s.StartsWith("A"));
            foreach (var item in NamenZoken)
            {
                Console.WriteLine(item);
            }
            //vraag 4
            Console.WriteLine("vraag 4");
            var GesorteerdeList = getallen.OrderByDescending(s => s);
            foreach (var item in GesorteerdeList)
            {
                Console.WriteLine(item);
            }
            //vraag 5
            Console.WriteLine("vraag5");
            var AantalElementen = Namen.Where(s => s.Contains("R"));
            foreach (var item in AantalElementen)
            {
                Console.WriteLine(item);
            }
            //  Console.WriteLine(AantalElementen);
            //vraag 6
            Console.WriteLine("vraag 6");
            var MaximaalGetal = getallen.Max(s => s);
            Console.WriteLine(MaximaalGetal);
            //vraag 7
            Console.WriteLine("vraag 7");
            var GemiddeldeBerekenen = getallen.Average(s => s);
             Console.WriteLine(GemiddeldeBerekenen);
            //vraag 8
            Console.WriteLine("vraag 8");
            var EersteElement = getallen.FirstOrDefault();
            var LaatsteElement = getallen.Last();
            Console.WriteLine(EersteElement);
            Console.WriteLine(LaatsteElement);
            //vraag 9
            Console.WriteLine("vraag 9");
            var BevatLijstEenSpecifiekElement = getallen.Contains(2);
            Console.WriteLine(BevatLijstEenSpecifiekElement);
            //vraag 10
            Console.WriteLine("vraag 10");
            var GroeperenOpEersteLetter = Namen.GroupBy(s => s[0]);
            foreach (var item in GroeperenOpEersteLetter)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }

        }

    }
}
