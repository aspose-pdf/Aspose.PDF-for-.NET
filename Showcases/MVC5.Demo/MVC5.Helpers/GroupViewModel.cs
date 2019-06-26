namespace MVC5.Helpers
{
    using System.Collections.Generic;

    public class GroupViewModel<K, T>
    {
        public K Key;
        public IEnumerable<T> Values;
    }
}
