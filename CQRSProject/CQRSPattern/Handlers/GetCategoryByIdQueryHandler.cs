using AutoMapper;
using CQRSProject.CQRSPattern.Queries;
using CQRSProject.CQRSPattern.Results;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly SaleContext _saleContext;
        private readonly IMapper _mapper;
        public GetCategoryByIdQueryHandler(SaleContext saleContext, IMapper mapper)
        {
            _saleContext = saleContext;
            _mapper = mapper;
        }

        public GetCategoryQueryResult Handle(GetCategoryByIdQuery query)
        {
            var values = _saleContext.Categories.Find(query.Id);

            return new GetCategoryQueryResult
            {
                CategoryId = values.CategoryId,
                CategoryName = values.CategoryName
            };

        }
    }
}
