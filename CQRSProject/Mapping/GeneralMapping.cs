using AutoMapper;
using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Entities;

namespace CQRSProject.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category , CreateCategoryCommand>().ReverseMap();
            CreateMap<Product , CreateProductCommand>().ReverseMap();
        }
    }
}
