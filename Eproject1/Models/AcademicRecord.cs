namespace Eproject1.Models
{
    public class AcademicRecord
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

        public string Title { get; set; }        // e.g. "My Poem", "Nature Design"
        public string Description { get; set; }  // poem/story/quotation details
        public string FilePath { get; set; }     // optional: image/file upload
        public DateTime DatePosted { get; set; }

        // Evaluation (done by Staff)
        public string EvaluationStatus { get; set; }
        // Best, Better, Good, Moderate, Normal, Disqualified

        public string PositiveRemarks { get; set; }
        public string NegativeRemarks { get; set; }
        public string ImprovementAreas { get; set; }
    }
}
