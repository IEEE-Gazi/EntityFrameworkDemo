namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int OrderDetailId { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }

        public Category Category { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}