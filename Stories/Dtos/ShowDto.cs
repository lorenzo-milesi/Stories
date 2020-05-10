using Stories.Meta;

namespace Stories.Dtos
{
    public class ShowDto<TData> where TData : class
    {
        public TData Data { get; set; }

        public ShowDto(TData data)
        {
            Data = data;
        }
    }
}