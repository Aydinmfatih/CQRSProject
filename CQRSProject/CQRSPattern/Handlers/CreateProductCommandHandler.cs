using AutoMapper;
using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;
using CQRSProject.DAL.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly SaleContext _context;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(SaleContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(_mapper.Map<Product>(command));
            _context.SaveChanges();
        }
    }
}
