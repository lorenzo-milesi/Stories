using System;

namespace Stories.Meta
{
    public class IndexMeta
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Count { get; set; }
        public int LastPage => (int) Math.Ceiling((double) Count / (double) Limit);
        public string Resource { get; set; }
        public string Next
        {
            get
            {
                if (Page < LastPage)
                {
                    return $"/api/{Resource}?page={Page + 1}&limit={Limit}";
                }

                return "";
            }
        }
        public string Prec
        {
            get
            {
                if (Page > 1)
                {
                    return $"/api/{Resource}?page={Page - 1}&limit={Limit}";
                }

                return "";
            }
        }
    }
}