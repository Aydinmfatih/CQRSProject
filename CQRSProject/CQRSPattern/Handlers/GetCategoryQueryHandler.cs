using CQRSProject.CQRSPattern.Results;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetCategoryQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetCategoryQueryResult> Handle()
        {
            var values = _saleContext.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
            }).ToList();
            return values;  
        }
    }
}
