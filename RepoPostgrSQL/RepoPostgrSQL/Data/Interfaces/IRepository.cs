using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPostgrSQL.Data.Interfaces
{
    public interface IRepository
    {
        Task<EntityEntry<T>> Create<T>(T model) where T:class;
        Task<int> SaveChangesAsync();
        Task<bool> Remove<T>(int id);
        Task<bool> Update<T>(T model) where T : class;
        Task<IEnumerable<T>> GetAll<T>() where T : class;
    }
}
