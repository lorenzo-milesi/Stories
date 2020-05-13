using System.Collections.Generic;
using Stories.Meta.Relationships;

namespace Stories.Meta
{
    public class ProjectData : IModelData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Show => $"/api/Projects/{Id}";
        public int StoriesCount { get; set; }
    }
}