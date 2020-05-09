using System.ComponentModel.DataAnnotations.Schema;

namespace Stories.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public Project Project { get; set; }
    }
}