using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var article = ".NET is a software development framework developed by" +
                " Microsoft that allows developers to create applications for " +
                "Windows, macOS, and Linux operating systems. It provides a wide" +
                " range of tools and libraries that make it easier to build scalable," +
                " reliable, and secure applications. .NET supports multiple programming" +
                " languages, including C#, F#, and Visual Basic, and includes features " +
                "such as automatic memory management, garbage collection, and support" +
                " for asynchronous programming. With its cross-platform capabilities " +
                "and extensive library of tools and features, .NET has become a popular" +
                " choice for building a wide range of applications, from desktop software" +
                " to web and mobile applications.";

            Dictionary<char, List<string>> letterdictionary =
            new Dictionary<char, List<string>>();

            foreach (var word in article.Split(' '))
            {
                foreach (var ch in word)
                {
                    if (!letterdictionary.ContainsKey(char.ToLower(ch)))
                    {
                        letterdictionary.Add( char.ToLower(ch), new List<string> { word.ToLower() });
                    }
                    else
                    {
                        letterdictionary[char.ToLower(ch)].Add(word);
                    }
                }
            }
            foreach (var enter in letterdictionary)
            {
                Console.Write($"{enter.Key}:");
                foreach (var word in enter.Value)
                {
                    Console.WriteLine($"\t\t{ word}");
                } 
            }

        
        
        
        }
    }
}
