namespace CQRSProject.CQRSPattern.Queries
{
    public class GetCategoryByIdQuery
    {
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
