namespace BlazorApp1Assemply.Models
{
    public class Basket_s
    {
        public int basketId { get; set; }
        public int itemId { get; set; }
        public int quantity { get; set; }
        public decimal totoal { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }
}
