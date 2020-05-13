using System.Collections.Generic;

namespace Stories.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public Type Type { get; set; }
        public int TypeId { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public IEnumerable<BusinessRule> BusinessRules { get; set; }
    }
}