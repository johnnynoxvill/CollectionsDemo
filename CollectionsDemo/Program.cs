using System;
using System.Collections.Generic;


namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Linus Torvalds");
            Names.Add("Donald Knuth");
            Names.Add("Grace Hopper");
            Names.Add("Donald Knuth");
            Names.Add("Jean Bartik");

            
            Names.TrimExcess();
           
            Names.RemoveAt(3);
            Names.Remove("Donald Knuth");


            Console.WriteLine("Count of list; " + Names.Count.ToString());
            Console.WriteLine("Capacity of list: " + Names.Capacity.ToString());

            DisplayNames(Names);
        }

        private static void DisplayNames(List<string> Names)
        {
            for (int i = 0; i < Names.Count; ++i)
            {
                Console.WriteLine(i + 1 + "; " + Names[i]);

            }
            Console.WriteLine();
        }
    }
}
