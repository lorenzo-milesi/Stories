namespace Stories.Data
{
    public abstract class Repository
    {
        protected readonly StoriesContext Context;

        protected Repository(StoriesContext context)
        {
            Context = context;
        }
    }
}