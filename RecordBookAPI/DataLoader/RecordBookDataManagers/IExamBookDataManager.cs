using RecordBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordBookAPI.DataLoader.RecordBookDataManagers
{
    public interface IExamBookDataManager: IAsyncDataManager<ExamBook>
    {
        DataLoader<ExamBook> ExamBookLoader { get; }
    }
}
