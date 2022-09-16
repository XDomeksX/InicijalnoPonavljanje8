using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj od najmanje 3: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[n];
            for(int a = 0; a < 2; a++)
            {
                niz[a] = a;
                if(niz[a] == 1)
                {
                    for (int i = 2; i < n; i++)
                    {
                        niz[i] = niz[i - 1] + niz[i - 2];
                        if(i == n - 1)
                        {
                            Console.WriteLine(niz[i]);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
