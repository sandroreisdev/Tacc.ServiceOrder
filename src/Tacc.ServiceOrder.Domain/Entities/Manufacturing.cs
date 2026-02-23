namespace Tacc.ServiceOrder.Domain.Entities
{
    public class Manufacturing : BaseEntity
    {       
        public string Name { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}