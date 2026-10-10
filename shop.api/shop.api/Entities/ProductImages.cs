namespace shop.api.Entities
{
    public class ProductImages:BaseEntity
    {
        public int ProductId { get; set; }
        public bool IsMain { get; set; }
        public string Url { get; set; } = null!;
        public Product Product { get; set; }=null!;
    }
}
