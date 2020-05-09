using System.Collections.Generic;
using Stories.Meta;

namespace Stories.Dtos
{
    public class ProjectIndexDto
    {
        public IEnumerable<ProjectData> Data { get; set; }
        public ProjectIndexMeta Meta { get; set; }

        public ProjectIndexDto(IEnumerable<ProjectData> data, ProjectIndexMeta meta)
        {
            Data = data;
            Meta = meta;
        }


    }
}