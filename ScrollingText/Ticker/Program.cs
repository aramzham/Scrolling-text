using System;
using RunningLine;

namespace Ticker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Running Line";
            Console.ForegroundColor = ConsoleColor.Cyan;
            var rl = new RunningLineCreator();
            rl.AddAdvertisment("Վաճառվում է բնակարան Ղափանի կենտրոնում, կոդ DP154, գինը՝ պայմանագրային");
            rl.AddAdvertisment("Իջևանի կարատեի դպրոցն անց է կացնում մարզումներ 4 տարեկանից բարձր անձանց համար");
            rl.AddAdvertisment("Այստեղ կարող է լինել Ձեր գովազդը");

            rl.RunTheLine();

            Console.ReadKey();
        }
    }
}
