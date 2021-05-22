using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string> {"Oyuncak araba", "Cep Telefonu", "televizyon", "Tetris"};
            string item = "";
            // foreach (var p in products)
            // {
            //     if (p[0] == 'C')
            //     {
            //         item = p;
            //     }
            // }

            item = products.SingleOrDefault(p => p[0] == 'C');
            //item = products.FirstOrDefault(p => p.ToLower()[0] == 't');

            string firstItem = products.First();
            
            

            //List<string> selectedItems = new List<string>();
            var selectedItems = products.Where(p => p.ToLower()[0] == 't').ToList();
            
            // foreach (var p in products)
            // {
            //     if (p.ToLower()[0] == 't')
            //     {
            //         selectedItems.Add(p);
            //     }
            // }
            
            

            foreach (var selectedItem in selectedItems)
            {
                Console.WriteLine(selectedItem);
            }

            Console.WriteLine();
            Console.WriteLine(item);
            Console.WriteLine(firstItem);
        }
    }
}