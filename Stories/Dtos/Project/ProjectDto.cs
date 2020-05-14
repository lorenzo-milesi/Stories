namespace Stories.Dtos.Project
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Show => $"/api/Projects/{Id}";
        public int StoriesCount { get; set; }
    }
}