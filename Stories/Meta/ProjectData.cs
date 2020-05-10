namespace Stories.Meta
{
    public class ProjectData : ModelData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Show => $"/api/Projects/{Id}";
    }
}