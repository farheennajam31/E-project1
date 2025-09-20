namespace Eproject1.Models
{
    public class Staff : User
    {
        public int Id { get; set; } 

        public string Username { get; set; }
        public string Password { get; set; }  

        
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        
        public DateTime DateOfJoining { get; set; }
        public string ClassHandled { get; set; }
        public string SubjectHandled { get; set; }

       
        public string Remarks { get; set; }
    }
}
