using Stories.Meta;

namespace Stories.Dtos
{
    public class ShowDto
    {
        public IModelData Data { get; set; }

        public ShowDto(IModelData data)
        {
            Data = data;
        }
    }
}