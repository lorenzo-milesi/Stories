using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos
{
    public class TypeCreateDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Title { get; set; }

    }
}