using System;
using System.Collections.Generic;

namespace OtusInterfaceTask01
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetOne(Func<T, bool> predicate);
        void Add(T item);
    }
}