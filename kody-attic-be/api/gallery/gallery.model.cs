namespace KodyAtticBE.Models
{
    public class Item
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string Color { get; set; }
        public required string Year { get; set; }
        public required int Available { get; set; }

    }
}