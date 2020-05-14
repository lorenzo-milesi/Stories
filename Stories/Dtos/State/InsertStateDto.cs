using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos.State
{
    public class InsertStateDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Title { get; set; }
    }
}