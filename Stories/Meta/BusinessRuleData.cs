using Stories.Meta.Relationships;

namespace Stories.Meta
{
    public class BusinessRuleData : IModelData
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public StoryInBusinessRuleData Story { get; set; }
    }
}