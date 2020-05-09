namespace Stories.Meta
{
    public class ProjectIndexMeta
    {
        public int Id { get; set; }

        public string Show => $"/api/Projects/{Id}";
    }
}