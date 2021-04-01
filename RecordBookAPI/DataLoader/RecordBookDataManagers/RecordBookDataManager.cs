using Microsoft.EntityFrameworkCore;
using RecordBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordBookAPI.DataLoader.RecordBookDataManagers
{
    public class RecordBookDataManager : IRecordBookDataManager
    {
        public RecordBookDataManager(DbContext context)
        {
            DepartmentLoader = new DataLoader<Department>(context);
            DisciplineLoader = new DataLoader<Discipline>(context);
            ExamBookLoader = new DataLoader<ExamBook>(context);
            ExamTypeLoader = new DataLoader<ExamType>(context);
            GroupLoader = new DataLoader<Group>(context);
            StudentLoader = new DataLoader<Student>(context);
        }
        #region DataLoaders
        public DataLoader<Department> DepartmentLoader { get; }

        public DataLoader<Discipline> DisciplineLoader { get; }

        public DataLoader<ExamBook> ExamBookLoader { get; }

        public DataLoader<ExamType> ExamTypeLoader { get; }

        public DataLoader<Group> GroupLoader { get; }

        public DataLoader<Student> StudentLoader { get; }
        #endregion

        #region AddItems
        public async Task<bool> AddItem(Department item)
        {
            return await DepartmentLoader.AddItem(item);
        }
        public async Task<bool> AddItem(Discipline item)
        {
            return await DisciplineLoader.AddItem(item);
        }

        public async Task<bool> AddItem(ExamBook item)
        {
            return await ExamBookLoader.AddItem(item);
        }

        public async Task<bool> AddItem(ExamType item)
        {
            return await ExamTypeLoader.AddItem(item);
        }

        public async Task<bool> AddItem(Group item)
        {
            return await GroupLoader.AddItem(item);
        }

        public async Task<bool> AddItem(Student item)
        {
            return await StudentLoader.AddItem(item);
        }
        #endregion

        #region RemoveItems
        public async Task<bool> RemoveItem(Department item)
        {
            return await DepartmentLoader.RemoveItem(item);
        }
        public async Task<bool> RemoveItem(Discipline item)
        {
            return await DisciplineLoader.RemoveItem(item);
        }

        public async Task<bool> RemoveItem(ExamBook item)
        {
            return await ExamBookLoader.RemoveItem(item);
        }

        public async Task<bool> RemoveItem(ExamType item)
        {
            return await ExamTypeLoader.RemoveItem(item);
        }

        public async Task<bool> RemoveItem(Group item)
        {
            return await GroupLoader.RemoveItem(item);
        }

        public async Task<bool> RemoveItem(Student item)
        {
            return await StudentLoader.RemoveItem(item);
        }
        #endregion
    }
}
