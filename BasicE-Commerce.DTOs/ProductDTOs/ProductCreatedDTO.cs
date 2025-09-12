namespace BasicE_Commerce.DTOs.PtoductDTOs
{
    public class ProductCreatedDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
    }
}
