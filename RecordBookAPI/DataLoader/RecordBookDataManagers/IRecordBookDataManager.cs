using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecordBookAPI.Models;
namespace RecordBookAPI.DataLoader.RecordBookDataManagers
{
    public interface IRecordBookDataManager: IDepartmentDataManager, IDisciplineDataManager, IExamBookDataManager, IExamTypeDataManager, IGroupDataManager, IStudentDataManager
    {
        async void SaveAllChanges() {
           await DepartmentLoader.SaveChanges();
        }
    }
}
