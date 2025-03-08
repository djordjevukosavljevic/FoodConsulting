using AutoMapper;
using FoodConsluting.Data;
using FoodConsluting.Models;
using FoodConsluting.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodConsluting.Services
{
    public interface IStandardService
    {

        public List<StandardModel> GetAll();

        // public Standard GetById(int id);
    }

    public class StandardService : IStandardService
    {
        private readonly IStandardRepository repository;

        private readonly IMapper mapper;


        public StandardService(IStandardRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<StandardModel> GetAll()
        {
            var resulltFromDb = repository.GetAll();
            var resultModels = mapper.Map<List<StandardModel>>(resulltFromDb);
            return resultModels;
        }

        // public Standard GetById(int id)
        // {
        //     var resultFromDb = repository.GetOne(id);
        //     var resultModel = mapper.Map<Standard>(resultFromDb);
        //     return resultModel;
        // }
    }
}
