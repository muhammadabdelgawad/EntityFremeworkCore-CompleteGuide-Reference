namespace EFCore.Models
{
    public class RecordOfSale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Price { get; set; }
       
        public string CarLicensePlate { get; set; }
        public Car Car { get; set; } // Navigation property
    }
}
