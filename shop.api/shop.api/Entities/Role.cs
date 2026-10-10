namespace shop.api.Entities
{
    public class Role: BaseEntity
    {
        public string Name { get; set; } = null!;
        public string DisplayName { get; set; }=null!;
    }
}
