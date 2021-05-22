using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public decimal Price { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}