﻿using System;
using RunningLine;

namespace Ticker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var rl = new RunningLineCreator();
            rl.Advertisments.Add("Վաճառվում է բնակարան Ղափանի կենտրոնում, կոդ DP154, գինը՝ պայմանագրային");
            rl.Advertisments.Add("Իջևանի կարատեի դպրոցն անց է կացնում մարզումներ 4 տարեկանից բարձր անձանց համար");
            rl.Advertisments.Add("Այստեղ կարող է լինել Ձեր գովազդը");

            rl.RunTheLine();

            Console.ReadKey();
        }
    }
}
