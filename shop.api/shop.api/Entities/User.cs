namespace shop.api.Entities
{

    public class User : BaseEntity
    {
        
        public string FirstName { get; set; }=null!;
        public string Lastname { get; set; }=null!;
        public string Mobile { get; set; }=null!;
        public  string PasswordHash { get; set; }=null!;
        public  List<UserRole> Roles { get; set; } = null!;

    }
}
