namespace Supermarket.API.Domain.Models
{
    public class Product
    {
        public int id { get; set; }
        
        public string Name { get; set; }
        
        public short QuantityInPackage { get; set; }
        
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}