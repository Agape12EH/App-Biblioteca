using App_Biblioteca.Models.Enums;

namespace App_Biblioteca.Models
{
    public class StateBook
    {
        public int Id { get; set; }
        public StatesOfBooks State { get; set; }
        public DateTime Registrationdate { get; set; }
        public string TakenActions { get; set; }

        //User Resposability
        public User UserActor { get; set; }
        //Book Affected
        public Books Book { get; set; }
    }
}
