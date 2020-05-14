using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos.BusinessRule
{
    public class InsertBusinessRuleDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int StoryId { get; set; }
    }
}