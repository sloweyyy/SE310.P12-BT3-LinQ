using System;

namespace DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}