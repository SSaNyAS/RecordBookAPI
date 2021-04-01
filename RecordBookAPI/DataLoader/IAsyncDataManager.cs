using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordBookAPI.DataLoader
{
    public interface IAsyncDataManager<T> where T : class
    {
        Task<bool> AddItem(T item);
        Task<bool> RemoveItem(T item);
    }
}
