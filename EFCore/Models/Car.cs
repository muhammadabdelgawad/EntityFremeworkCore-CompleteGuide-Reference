namespace EFCore.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Mode { get; set; }
        public List<RecordOfSale> SaleHistory { get; set; }
    }
}
