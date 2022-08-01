using Microsoft.EntityFrameworkCore.ChangeTracking;
using RepoPostgrSQL.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPostgrSQL.Data.Interfaces
{
    public interface IRepository
    {
        Task<EntityEntry<T>> Create<T>(T model) where T : class, IEntity;
        Task<int> SaveChangesAsync();
        Task<bool> Remove<T>(int id) where T:class, IEntity;
        Task<bool> Update<T>(T model) where T : class, IEntity;
        Task<IEnumerable<T>> GetAll<T>() where T : class, IEntity;
    }
}
