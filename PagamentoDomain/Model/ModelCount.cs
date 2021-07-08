using System.Collections.Generic;

namespace PagamentoDomainModel
{
    public class ModelCount<T>
    {
        public int Count { get; set; }
        public List<T> ModelList { get; set; }
    }
}
