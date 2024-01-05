using App_Biblioteca.DTOs;
using App_Biblioteca.Models;
using AutoMapper;

namespace App_Biblioteca.Services
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<Books, BooksDTO>();
            CreateMap<Inventory, InventoryDTO>();
            CreateMap<Loan, LoanDTO>();
            CreateMap<StateBook, StateBookDTO>();
            CreateMap<User, UserDTO>();
        }
    }
}
