using System;

namespace lab7_genercs
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayInt = new int[] { 1, 4, 5, 9, 6, 6 };
            var arrayDouble = new double[] { 1.4, 2.3, 2.3, 4.2, 3.35, 3 };
            var arrayString = new string[] { "apple", "apple", "pear" };
            Console.WriteLine(IsEqualPair(arrayInt));
            Console.WriteLine(IsEqualPair(arrayDouble));
            Console.WriteLine(IsEqualPair(arrayString));
        }

        public static bool IsEqualPair<T>(T[] array)
            where T: IEquatable<T>
        { 
            for (var i = 0; i < array.Length; i++)
            {
                if ((dynamic)array[i] == (dynamic)array[i+1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
