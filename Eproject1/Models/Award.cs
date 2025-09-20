namespace Eproject1.Models
{
    public class Award
    {
        public int Id { get; set; }

        // Student (FK)
        public int StudentId { get; set; }
        public Student Student { get; set; }

        // Competition (FK)
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

        // Award Details
        public string AwardName { get; set; }     // Example: "Gold Medal", "Certificate", "Cash Prize"
        public DateTime AwardDate { get; set; }
        public string Remarks { get; set; }
    }
}
