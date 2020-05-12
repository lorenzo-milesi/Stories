using Stories.Models;

namespace Stories.Meta
{
    public class StoryData : IModelData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public Project Project { get; set; }
    }
}