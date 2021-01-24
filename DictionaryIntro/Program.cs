using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Numbers = new MyDictionary<int, string>();
            Numbers.Add(1,"bir");
            Numbers.Add(2, "iki");
            Numbers.Add(3, "üç");

            Console.WriteLine( Numbers.Find(1) ); 
        }
    }
}
