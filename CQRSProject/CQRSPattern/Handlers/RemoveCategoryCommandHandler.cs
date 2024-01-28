using CQRSProject.CQRSPattern.Commands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public RemoveCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }
        public void Handle(RemoveCategoryCommand command)
        {
            var values = _context.Categories.Find(command.Id);
            _context.Categories.Remove(values);
            _context.SaveChanges();
        }

    }
}
