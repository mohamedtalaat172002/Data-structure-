using System;
using System.Collections.Generic;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<printingjob> printingjobs = new Queue<printingjob>();

            printingjobs.Enqueue(new printingjob("first file", 8));
            printingjobs.Enqueue(new printingjob("seconed file", 4));
            printingjobs.Enqueue(new printingjob("third file", 2));
            printingjobs.Enqueue(new printingjob("fourth file", 6));

            Random rnd = new Random();
            while (printingjobs.Count > 0)
            {
                var job = printingjobs.Dequeue();
                Console.WriteLine($"currently printing...{job}");
                System.Threading.Thread.Sleep(rnd.Next(1, 3) * 1000);

            }
            Console.ReadKey();

        }
    }
    class printingjob
    {
        private readonly string _file;
        private readonly int _copies;

        public printingjob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }
        public override string ToString()
        {
            return $"{_file} is printed {_copies} copies";
        }
    }
}