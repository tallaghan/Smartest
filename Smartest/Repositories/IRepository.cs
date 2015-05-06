using System;
using System.Linq;
namespace Smartest.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
    }
}
