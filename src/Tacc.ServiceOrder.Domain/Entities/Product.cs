namespace Tacc.ServiceOrder.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Manufacturing Manufature { get; set; } = null;
        public int ManufactureId { get; set; }
    }
}