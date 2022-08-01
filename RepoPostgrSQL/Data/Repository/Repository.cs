using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RepoPostgrSQL.Data.Interfaces;
using RepoPostgrSQL.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPostgrSQL.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<EntityEntry<T>> Create<T>(T model) where T : class, IEntity
        {
            try
            {
                var entity = await _context.AddAsync(model);
                return entity;
            }
            catch
            {
                //log
                return null;
            }
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class, IEntity
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> Remove<T>(int id) where T : class, IEntity
        {
            if (id > 0)
            {
                var model = await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
                if (model != null)
                {
                    _context.Set<T>().Remove(model);
                    return true;
                }
                return false;
            }
            return false;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update<T>(T model) where T : class, IEntity
        {
            throw new NotImplementedException();
        }
    }
}
