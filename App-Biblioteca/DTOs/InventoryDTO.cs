namespace App_Biblioteca.DTOs
{
    public class InventoryDTO
    {
        public int QuantityAvailable { get; set; }
        public int QuantityTotal { get; set; }
        public BooksDTO Book { get; set; }
    }
}
