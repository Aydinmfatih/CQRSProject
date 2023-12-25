using CQRSProject.CQRSPattern.Queries;
using CQRSProject.CQRSPattern.Results;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetCategoryByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public GetCategoryQueryResult Handle(GetCategoryByIdQuery query)
        {
            var values = _saleContext.Categories.Find(query.Id);
            return null;
        }
    }
}
