using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos.Scenario
{
    public class InsertScenarioDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int StoryId { get; set; }
    }
}