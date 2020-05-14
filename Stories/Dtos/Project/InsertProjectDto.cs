using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos.Project
{
    public class InsertProjectDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Name { get; set; }
    }
}