namespace Eproject1.Models
{
    public class Manager : User
    {
        public int ManagerId { get; set; }

        // Relation with User (Login purpose)
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public string Department { get; set; } = string.Empty; // e.g. Arts, Exhibitions
        public DateTime JoinedDate { get; set; }
    }
}
