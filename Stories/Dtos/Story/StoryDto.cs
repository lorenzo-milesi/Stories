using System.Collections.Generic;
using Stories.Dtos.BusinessRule;
using Stories.Dtos.Project;
using Stories.Dtos.Scenario;

namespace Stories.Dtos.Story
{
    public class StoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public ProjectDto Project { get; set; }
        public Models.Type Type { get; set; }
        public Models.State State { get; set; }
        public IEnumerable<IndexBusinessRuleDto> BusinessRules { get; set; }
        public IEnumerable<ScenarioDto> Scenarios { get; set; }
    }
}