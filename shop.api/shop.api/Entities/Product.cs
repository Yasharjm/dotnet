namespace shop.api.Entities
{
    public class Product :BaseEntity
    {
        public int CategoryId { get; set; }
        public string  Name { get; set; } =null!;
        public long  Price { get; set; }
        public ProductCategory Category { get; set; } = null!;
        public List<ProductImages> Images { get; set; } = null!;

    }
}
