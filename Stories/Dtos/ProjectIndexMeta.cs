using System.Runtime.Serialization;

namespace Stories.Dtos
{
    public class ProjectIndexMeta
    {
        public int Id { get; set; }

        public string Show => $"/api/Projects/{Id}";
    }
}