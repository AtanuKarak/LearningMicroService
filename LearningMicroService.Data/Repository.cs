using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningMicroService.Data
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {
        private readonly PeopleDbContext _peopleDbContext;

        public Repository(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public List<TEntity> GetAll()
        {
           return _peopleDbContext.Set<TEntity>().ToList();
        }
    }
}
