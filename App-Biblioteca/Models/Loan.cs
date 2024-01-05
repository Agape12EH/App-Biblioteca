using App_Biblioteca.Models.Enums;

namespace App_Biblioteca.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public Guid GuidLoan { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public StatesOfLoans LoanState { get; set; }

        //Books
        public List<Books> Books { get; set; }

        //User
        public User User { get; set; }
    }
}
