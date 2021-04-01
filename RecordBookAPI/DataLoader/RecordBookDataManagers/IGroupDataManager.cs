using RecordBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordBookAPI.DataLoader.RecordBookDataManagers
{
    public interface IGroupDataManager: IAsyncDataManager<Group>
    {
        DataLoader<Group> GroupLoader { get; }
    }
}
