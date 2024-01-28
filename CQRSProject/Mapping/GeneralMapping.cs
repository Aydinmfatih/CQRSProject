using AutoMapper;
using CQRSProject.CQRSPattern.Commands;
using CQRSProject.CQRSPattern.Queries;
using CQRSProject.CQRSPattern.Results;
using CQRSProject.DAL.Entities;

namespace CQRSProject.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category , CreateCategoryCommand>().ReverseMap();
            CreateMap<Product , CreateProductCommand>().ReverseMap();
            CreateMap<Category , GetCategoryQueryResult>().ReverseMap();
        }
    }
}
