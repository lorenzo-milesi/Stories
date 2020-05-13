using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos
{
    public class BusinessRuleCreateDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int StoryId { get; set; }
    }
}