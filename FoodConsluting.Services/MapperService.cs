using FoodConsluting.Data;
using AutoMapper;
using FoodConsluting.Models;

namespace FoodConsluting.Services
{
    public class MapperService : Profile
    {

        public MapperService(){
            CreateMap<Standard, StandardModel>().ReverseMap();
            
        }
    }
}
