using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Models;
using EvoJiuJitsu.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly EvoDbcontext _db;
        protected readonly DbSet<TEntity> _DbSet;

        public Repository(EvoDbcontext db)
        {
            _db = db;

            _DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await _DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> Obtertodos()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task Adicionar(TEntity entity)
        {
            _DbSet.Add(entity);
            await SaveChange();
        }

        public async Task Atualizar(TEntity entity)
        {
            _DbSet.Update(entity);
            await SaveChange();
        }

        public async Task Remover(Guid id)
        {
            _DbSet.Remove(new TEntity { Id = id });
            await SaveChange();
        }

        public async Task<int> SaveChange()
        {
            return await _db.SaveChangesAsync();
        }
        public void Dispose()
        {
            _db?.Dispose();
        }

    }
}
