namespace MarketApp.WebUI.Areas.Admin.Models
{
    public class ResultModel
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? CategoryName { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }

    }
}
