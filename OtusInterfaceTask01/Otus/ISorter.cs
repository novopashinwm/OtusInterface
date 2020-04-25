using System.Collections.Generic;

namespace OtusInterfaceTask01
{
    public interface ISorter<T>
    {
        IEnumerable<T> Sort(IEnumerable<T> notSortedItems);
    }
}