using System.Collections.Generic;
using Stories.Meta;

namespace Stories.Dtos
{
    public class IndexDto
    {
        public IEnumerable<ModelData> Data { get; }
        public IndexMeta Meta { get; }

        public IndexDto(IEnumerable<ModelData> data, IndexMeta meta)
        {
            Data = data;
            Meta = meta;
        }
    }
}