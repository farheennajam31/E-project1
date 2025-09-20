namespace Eproject1.Models
{
    public class Submission
    {
        public int SubmissionId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; } = null!;
        public string FilePath { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; } = "Pending"; // Pending / Approved / Rejected
    }
}
