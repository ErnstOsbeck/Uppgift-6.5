using System;

namespace uppgift_6._5
{
    class program
    {
        static void Main(string[] args)
        {
            Längst("hej", "hallå");
        }
        static void Längst(string ord1, string ord2)
        {
            int Längd1 = ord1.Length;
            int Längd2 = ord2.Length;

            if(Längd1 > Längd2)
            {
                Console.WriteLine(ord1);
            }
            else if (Längd1 < Längd2)
            {
                Console.WriteLine(ord2);
            }
            else if (Längd1 == Längd2)
            {
                Console.WriteLine(ord1);
            }
        }
    }
}
