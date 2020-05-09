using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos
{
    public class ProjectCreateDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Name { get; set; }
    }
}