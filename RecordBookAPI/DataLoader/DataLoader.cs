using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RecordBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace RecordBookAPI.DataLoader
{
    public class DataLoader<T> : IAsyncDataManager<T> where T: class
    {
        private const int MillisecondsTimeout = 10000;
        public bool IsAutoSaveEnabled { get; set; } = true;
        public DbContext Context { get; private set; }
        private DbSet<T> Set => Context.Set<T>();
        public DataLoader(DbContext context)
        {
            this.Context = context;
        }
        
        public async Task<LocalView<T>> GetAllAsync()
        {
            await Set.LoadAsync();
            return Set.Local;
        }

        public async Task<IEnumerable<T>> GetListWhere(Func<T,bool> expression)
        {
            var result = await Task.Run(()=> Set.Where(expression));
            return result;
        }

        public async Task<bool> AddItem(T item)
        {
            var task = Set.AddAsync(item);
            await task;

            if (IsAutoSaveEnabled)
                return await SaveChanges();

            return task.IsCompletedSuccessfully;
        }
        public async Task<bool> RemoveItem(T item)
        {
            var findItem = await Set.FindAsync(item);

            if (findItem != null)
            {
                Set.Remove(findItem);
                if (IsAutoSaveEnabled)
                    return await SaveChanges();
            }

            return false;
        }

        public async Task<bool> SaveChanges()
        {
            return (await Context.SaveChangesAsync() > 0);
        }
        public async Task<bool> UpdateItem(T item)
        {
            Context.Entry<T>(item).State = EntityState.Modified;
            return await SaveChanges();
        }
    }
}
