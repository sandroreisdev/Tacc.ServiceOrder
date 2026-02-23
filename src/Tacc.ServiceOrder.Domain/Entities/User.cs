namespace Tacc.ServiceOrder.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? IpAdress { get; set; }
        public string? Phone { get; set; }
        public string? ProfileImage { get; set; }
    }
}