using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RunningLine
{
    public class RunningLineCreator
    {
        public RunningLineCreator()
        {

        }

        public RunningLineCreator(string text)
        {
            this.Advertisments.Add(text);
        }

        public List<string> Advertisments { get; set; } = new List<string>();

        public void RunTheLine()
        {
            var allText = string.Join("", Advertisments.Select(t => t + new string(' ', 4)));
            var visibleOnConsole = allText.ToList().GetRange(0, 80);
            var notVisible = allText.ToList().GetRange(80, allText.Length - 80);
            char c;

            while (true)
            {
                Console.Clear();
                Console.Write(new string(visibleOnConsole.ToArray()));
                Thread.Sleep(200);
                c = visibleOnConsole[0];
                visibleOnConsole.RemoveAt(0);
                notVisible.Add(c);
                visibleOnConsole.Add(notVisible[0]);
                notVisible.RemoveAt(0);
            }
        }
    }
}
