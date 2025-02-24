namespace DemoMvc.Models
{
    public class BMICalculator
    {
        public float Weight { get; set; } 
        public float Height { get; set; } 
        public float BMI => (Height > 0) ? Weight / (Height * Height) : 0;
    }
}
