namespace DemoMvc.Models
{
    public class BillCalculator
    {
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float Total => Quantity * UnitPrice;
    }
}
