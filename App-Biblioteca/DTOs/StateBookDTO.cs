namespace App_Biblioteca.DTOs
{
    public class StateBookDTO
    {
        public string State { get; set; }
        public DateTime Registrationdate { get; set; }
        public BooksDTO Book { get; set; }
    }
}
