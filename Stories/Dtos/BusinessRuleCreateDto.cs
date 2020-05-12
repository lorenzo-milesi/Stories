using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos
{
    public class BusinessRuleCreateDto
    {
        [Required]
        public string Description { get; set; }
    }
}