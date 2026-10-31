

namespace Survey.Domain.Dtos
{
    public class OptionVotePercentageDto
    {
        public int OptionId { get; set; }
        public string OptionTitle { get; set; }
        public double Percentage { get; set; }
    }
}
