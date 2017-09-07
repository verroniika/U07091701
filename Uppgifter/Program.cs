using System;
using System.Collections;
using System.Linq;

namespace Uppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            ArrayList list = new ArrayList();
            Product p = new Product();
            list.Add(new Product() { Name = "Drömmar", Price = 7 });
            list.Add(new Product() { Name = "Havreflarn", Price = 5 });
            list.Add(new Product() { Name = "Finska pinnar", Price = 4 });
            list.Add(new Product() { Name = "Hallongrottor", Price = 10 });
            list.Add(new Product() { Name = "Salta kex", Price = 3 });


            int c = list.Count;

            Console.WriteLine("Det finns " + c + "st produkter i listan\n");

            foreach (Product x in list)
            {
                Console.Write("| " + x.Name + " " + x.Price + "kr ");
            }

            foreach (Product i in list)
            {
                if (i.Price > max)
                {
                    max = i.Price;
                }
            }
            Console.WriteLine("\n\nDen dyraste produkten kostar: " + max + "kr");
            Console.Write("\n");

            double sum = 0;
            foreach (Product x in list)
            {
                sum += x.Price;
            }
            double medel = sum / list.Count;
            Console.WriteLine("Snittpriset på alla produkter är: " + medel + "kr");
            Console.Write("\n");

            foreach (Product x in list)
            {
                Console.WriteLine(x.Name + " " + x.Price + "kr ");
            }
            Console.Write("\n");
        }
    }
}
