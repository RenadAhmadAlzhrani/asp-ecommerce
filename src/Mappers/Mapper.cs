using AutoMapper;
using CodeCrafters_backend_teamwork.src.DTOs;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserReadDto, User>();
            CreateMap<UserCreateDto, User>();
        }
    }
}