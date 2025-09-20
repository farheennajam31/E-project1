namespace Eproject1.Models
{
    public class Student : User
    {
        public int Id { get; set; }   

        public string Username { get; set; }
        public string Password { get; set; }   

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public DateTime DateOfAdmission { get; set; }
        public string GradeLevel { get; set; }  
        public string Remarks { get; set; }
    }
}
