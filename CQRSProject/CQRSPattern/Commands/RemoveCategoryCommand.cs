namespace CQRSProject.CQRSPattern.Commands
{
    public class RemoveCategoryCommand
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
