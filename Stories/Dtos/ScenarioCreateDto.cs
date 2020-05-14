using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos
{
    public class ScenarioCreateDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int StoryId { get; set; }
    }
}