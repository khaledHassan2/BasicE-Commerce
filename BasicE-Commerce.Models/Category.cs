namespace BasicE_Commerce.Models
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
