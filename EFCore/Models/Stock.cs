using System.Data.SqlTypes;

namespace EFCore.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public double Balance { get; set; }


    }
}
