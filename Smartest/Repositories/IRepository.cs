using System;
namespace Smartest.Repositories
{
    public interface IRepository<T>
    {
        System.Linq.IQueryable<T> GetAll();
    }
}
