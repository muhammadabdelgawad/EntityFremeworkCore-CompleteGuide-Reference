namespace EFCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public long OrderNo { get; set; }
        public double Amount { get; set; }
        public bool IsDeleted { get; set; }
    }
}
