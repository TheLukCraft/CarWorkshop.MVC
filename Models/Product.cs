namespace CarWorkshop.MVC.Models
{
    public class Product
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}
