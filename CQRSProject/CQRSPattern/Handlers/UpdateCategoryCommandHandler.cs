using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public UpdateCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }
        public void Handle(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryId);
            values.CategoryName = command.CategoryName;
            _context.SaveChanges(); 
        }
    }
}
