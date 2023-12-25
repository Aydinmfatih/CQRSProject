using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;
using CQRSProject.DAL.Entities;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public CreateCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }
        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            _context.SaveChanges();
                
        }
    }
}
