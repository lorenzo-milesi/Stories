using Stories.Dtos.Project;

namespace Stories.Dtos.Story
{
    public class IndexStoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public ProjectDto Project { get; set; }
        public Models.Type Type { get; set; }
        public Models.State State { get; set; }
    }
}