using Stories.Meta;

namespace Stories.Dtos
{
    public class ProjectIndexDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProjectIndexMeta Meta
        {
            get
            {
                ProjectIndexMeta meta = new ProjectIndexMeta { Id = Id };
                return meta;
            }
        }
    }
}