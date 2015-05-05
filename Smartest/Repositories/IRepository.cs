using System;
namespace Smartest.Repositories
{
    interface IRepository<T>
    {
        System.Linq.IQueryable<T> GetAll();
    }
}
