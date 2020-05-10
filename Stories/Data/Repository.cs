using Stories.Models;

namespace Stories.Data
{
    public abstract class Repository
    {
        protected readonly StoriesContext Context;

        protected Repository(StoriesContext context)
        {
            Context = context;
        }

        public bool Store()
        {
            return (Context.SaveChanges() >= 0);
        }
    }
}