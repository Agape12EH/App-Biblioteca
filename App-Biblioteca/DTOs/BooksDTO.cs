namespace App_Biblioteca.DTOs
{
    public class BooksDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Gender { get; set; }
        public DateOnly AgePublication { get; set; }
        public List<StateBookDTO> StateBook { get; set; }
        public InventoryDTO Inventory { get; set; }
        public List<LoanDTO> Loans { get; set; }
    }
}
