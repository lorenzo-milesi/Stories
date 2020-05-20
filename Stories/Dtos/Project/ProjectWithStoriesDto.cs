using System.Collections.Generic;
using Stories.Dtos.Story;

namespace Stories.Dtos.Project
{
    public class ProjectWithStoriesDto : ProjectDto
    {
        public IEnumerable<IndexStoryDto> Stories { get; set; }
    }
}