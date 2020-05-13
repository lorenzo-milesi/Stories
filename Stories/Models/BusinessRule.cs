namespace Stories.Models
{
    public class BusinessRule
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Story Story { get; set; }
        public int StoryId { get; set; }
    }
}