using System.Collections.Generic;

namespace OtusInterfaceTask01
{
    public interface ISorter<T>
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> notSortedItems);
    }
}