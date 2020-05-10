using System.Collections;
using System.Collections.Generic;
using Stories.Meta;

namespace Stories.Dtos
{
    public class IndexDto
    {
        public IEnumerable Data { get; }
        public IndexMeta Meta { get; }

        public IndexDto(IEnumerable data, IndexMeta meta)
        {
            Data = data;
            Meta = meta;
        }
    }
}