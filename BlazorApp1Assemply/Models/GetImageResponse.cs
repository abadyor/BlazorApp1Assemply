namespace BlazorApp1Assemply.Models
{
    public class GetImageResponse
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageName { get; set; } // مسار الصورة
        public string TableName { get; set; }
        public string OldImageName { get; set; } = string.Empty;
    }
}
