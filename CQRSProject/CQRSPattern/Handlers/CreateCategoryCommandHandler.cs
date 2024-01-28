using AutoMapper;
using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;
using CQRSProject.DAL.Entities;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly SaleContext _context;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(SaleContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle(CreateCategoryCommand command)
        {
           var value = _mapper.Map<Category>(command);
            _context.Categories.Add(value);
            _context.SaveChanges();
                
        }
    }
}
