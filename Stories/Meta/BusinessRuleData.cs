using System.ComponentModel.DataAnnotations;

namespace Stories.Meta
{
    public class BusinessRuleData : IModelData
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}