namespace Stories.Data
{
    public interface IRepository
    {
        bool Store();
        int Count();
    }
}