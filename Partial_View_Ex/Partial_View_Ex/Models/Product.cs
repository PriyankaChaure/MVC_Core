namespace Partial_View_Ex.Models
{
    public class Product
    {
        public Int64 ProductId { get; set; }
        public string ProductName { get; set; }
        public string MfgName {  get; set; }
        public decimal Price {  get; set; } 
        public Product()
        {
            this.ProductId = 1;
            this.ProductName = "Computer";
            this.MfgName = "HP";
            this.Price = 350;
        }
    }
}
