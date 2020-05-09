using Stories.Meta;

namespace Stories.Dtos
{
    public class ProjectShowDto
    {
        public ProjectData Data { get; set; }

        public ProjectShowDto(ProjectData data)
        {
            Data = data;
        }
    }
}