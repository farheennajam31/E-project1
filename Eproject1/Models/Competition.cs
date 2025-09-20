namespace Eproject1.Models
{
    public class Competition
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Conditions { get; set; }

        public string AwardDetails { get; set; }
    }
}
