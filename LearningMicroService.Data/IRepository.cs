using System;
using System.Collections.Generic;
using System.Text;

namespace LearningMicroService.Data
{
    public interface IRepository<TEntity> 
        where TEntity: class, new()
    {
        List<TEntity> GetAll();
    }
}
