using System.Collections.Generic;
using System.Linq;

namespace OtusInterfaceTask01
{
    public class PersonSorter : ISorter<Person>
    {
        public IEnumerable<Person> Sort(IEnumerable<Person> notSortedItems)
        {
            return notSortedItems.OrderBy(p => p);
        }
    }
}