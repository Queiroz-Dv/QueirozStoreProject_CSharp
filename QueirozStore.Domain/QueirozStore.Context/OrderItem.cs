namespace QueirozStore.Domain.QueirozStore.Context
{
  public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}