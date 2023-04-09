using System;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<comand> undo = new Stack<comand>();
            Stack<comand> redo = new Stack<comand>();

            string line;
            while (true)
            {
                Console.WriteLine($"enter the input: \n('exite'to quit,\n'back'to undo,\n'forwrd'to redo ):");
                line = Console.ReadLine().ToLower();

                if (line == "exite")
                {
                    break;
                }
                else if (line == "back")
                {
                    if (undo.Count > 0)
                    {
                        var item = undo.Pop();
                        redo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var item = redo.Pop();
                        undo.Push(item);
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    undo.Push(new comand(line));
                }
                Console.Clear();
                print("back", undo);
                print("forward", redo);
            }

        }

        static void print(string name, Stack<comand> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach (var u in commands)
            {
                Console.WriteLine($"\t{u}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    class comand
    {
        private readonly DateTime _createdAt;
        private readonly string _url;

        public comand(string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }

        public override string ToString()
        {
            return $"[{ this._createdAt.ToString("yyyy-MM-dd hh:mm")}] { this._url}";

        }
    }
}

