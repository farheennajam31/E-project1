namespace Eproject1.Models
{
    public class StudentSubmission
    {
        public int Id { get; set; }

        // Student
        public int StudentId { get; set; }
        public Student Student { get; set; }

        // Exhibition
        public int ExhibitionId { get; set; }
        public Exhibition Exhibition { get; set; }

        // Painting Details
        public string PaintingTitle { get; set; }
        public string FilePath { get; set; }   // painting image upload path
        public DateTime SubmissionDate { get; set; }

        public string Remarks { get; set; }
    }
}
