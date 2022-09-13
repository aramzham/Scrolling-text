using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RunningLine
{
    public class RunningLineCreator
    {
        private readonly List<string> _advertisments = new();
        private Queue<char> _visible;
        private Queue<char> _notVisible;

        public void AddAdvertisment(string text)
        {
            _advertisments.Add(text);
        }

        public void RunTheLine()
        {
            var text = $"{string.Join("    ", _advertisments)}    ";

            if(text.Length <= 80)
                text = text.PadRight(160);

            _visible = new Queue<char>(new string(' ', 80));
            _notVisible = new Queue<char>(text);

            var counter = 0;
            while (true)
            {
                Console.Clear();
                Console.Write(new string(_visible.ToArray()));
                Thread.Sleep(100);            

                if(counter < 80)
                {
                    _visible.Dequeue();
                    counter++;
                }
                else 
                    _notVisible.Enqueue(_visible.Dequeue());
                _visible.Enqueue(_notVisible.Dequeue());      
            }
        }
    }
}
