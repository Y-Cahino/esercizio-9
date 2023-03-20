using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire dimensione: ");
            int d=int.Parse(Console.ReadLine());
            int[] a = new int[d];
            int[] b = new int[d];
            Console.WriteLine("Inserire numero: ");
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine("Elemento {0}", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < d; i++)
            {
                b[d-i-1]=a[i];
            }
            Console.WriteLine(Environment.NewLine + "Valori invertiti: "); //forza l'andare a capo
            for(int i = 0; i < d; i++)
            {
                Console.WriteLine("{0}",b[i]);
            }
        }
    }
}
