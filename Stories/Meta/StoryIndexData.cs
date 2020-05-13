using Stories.Meta.Relationships;
using Stories.Models;

namespace Stories.Meta
{
    public class StoryIndexData : IModelData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public ProjectInStoryData Project { get; set; }
        public Type Type { get; set; }
        public State State { get; set; }
    }
}