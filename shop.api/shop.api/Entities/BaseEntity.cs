namespace shop.api.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreacted { get; set; } = DateTime.Now;

    }
}
