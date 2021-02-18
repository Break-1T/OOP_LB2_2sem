using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            
            Console.WriteLine(new string('-',30));

            int[] array = GetArray(myList);

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static T[] GetArray<T>(MyList<T> list)
        {
            T[] result = new T[list.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list[i];
            }

            return result;
        }
    }
}
