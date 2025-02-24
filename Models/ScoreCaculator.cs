namespace DemoMvc.Models
{
    public class ScoreCalculator
    {
        public float ScoreA { get; set; }
        public float ScoreB { get; set; }
        public float ScoreC { get; set; }
        public float Average => (ScoreA * 0.3f) + (ScoreB * 0.3f) + (ScoreC * 0.4f);
    }
}
