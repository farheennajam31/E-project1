namespace Eproject1.Models
{
    public class Exhibition
    {
        public int Id { get; set; }

        public string Title { get; set; }            // Exhibition ka naam
        public string Location { get; set; }         // Kahaan ho rahi hai (City, Hall, etc.)
        public DateTime StartDate { get; set; }      // Kab start hogi
        public DateTime EndDate { get; set; }        // Kab khatam hogi
        public string Description { get; set; }      // Extra info
        public string OrganizedBy { get; set; }      // Kisne organize kiya

        // Link with students’ submissions
        public ICollection<StudentSubmission> Submissions { get; set; }
    }
}
