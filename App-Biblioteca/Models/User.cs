namespace App_Biblioteca.Models
{
    public class User
    {
        public int Id { get; set; }
        public Guid UserGuid { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
