using System.Collections;
using System.Collections.Generic;
using Stories.Meta;

namespace Stories.Dtos
{
    public class IndexDto<TDto>
    {
        public IEnumerable<TDto> Data { get; }
        public IndexMeta Meta { get; }

        public IndexDto(IEnumerable<TDto> data, IndexMeta meta)
        {
            Data = data;
            Meta = meta;
        }
    }
}