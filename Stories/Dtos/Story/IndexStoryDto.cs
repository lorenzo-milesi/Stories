using Stories.Dtos.Project;
using Stories.Dtos.State;
using Stories.Dtos.Type;

namespace Stories.Dtos.Story
{
    public class IndexStoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public ProjectDto Project { get; set; }
        public TypeDto Type { get; set; }
        public StateDto State { get; set; }
    }
}