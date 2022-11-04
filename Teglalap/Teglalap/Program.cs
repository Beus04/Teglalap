using System;

namespace Teglalap
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap[] teglalapok = new Teglalap[10];

            for (int i = 0; i < 10; i++)
            {
                teglalapok[i] = new Teglalap();
            }

            foreach (var item in teglalapok)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

             
            
            

        }
    }
}
