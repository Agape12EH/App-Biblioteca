namespace App_Biblioteca.Models
{
    public class Books
    {
        public int Id { get; set; }
        public Guid guidBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Gender { get; set; }
        public DateOnly AgePublication { get; set; }

        //Inventories
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        //registeres and Loans
        public List<StateBook> StateBook { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
