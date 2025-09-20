namespace Eproject1.Models
{
    public class Sale
    {
        public int SaleId { get; set; }  // Primary Key (Required)

        // Exhibition relation
        public int ExhibitionId { get; set; }
        public Exhibition Exhibition { get; set; } = null!;

        // Original design / artwork reference
        public int SubmissionId { get; set; }
        public Submission Submission { get; set; } = null!;

        public int BuyerId {  get; set; } // if only studentcan buy, make this studentId
        public User Buyer { get; set; } = null!;

        public DateTime? SoldDate { get; set; } // When it was sold
    }
}
