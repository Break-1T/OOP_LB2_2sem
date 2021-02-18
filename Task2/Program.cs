using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1,"First");
            myDictionary.Add(2,"Second");
            myDictionary.Add(3,"Third");
            myDictionary.Add(58,"Pitdesyat vosem");
            myDictionary.Add(164, "Random number");
            myDictionary[3] = "Уже не 3";
            foreach (var i in myDictionary._keyArray)
            {
                Console.WriteLine(myDictionary[i]);
            }
            Console.WriteLine($"Count: {myDictionary.Count}");
        }
    }
}
