using CQRSProject.CQRSPattern.Results;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetProductQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _saleContext.Products.Select(x => new GetProductQueryResult
            {
                Price = x.Price,
                ProductName = x.ProductName,
                ProductId = x.ProductId,
                Stock = x.Stock,
                CategoryId = x.CategoryId,
            }).ToList();
            return values;  
        }
    }
}
