using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos.Type
{
    public class InsertTypeDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Title { get; set; }
    }
}