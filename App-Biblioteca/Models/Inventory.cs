namespace App_Biblioteca.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public DateTime dateInventory { get; set; }
        public int QuantityAvailable { get; set; }
        public int QuantityTotal { get; set; }

        //same Books       
        public List<Books> Books { get; set; }
    }
}
