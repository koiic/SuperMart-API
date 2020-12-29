namespace Supermarket.API.Resources
{
    public class ProductResource
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int QuantityInPackage { get; set; }
        public string UnitOfMeasurement { get; set; }
        public CategoryResource Category { get; set; }
        
    }
}