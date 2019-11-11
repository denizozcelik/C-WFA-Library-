using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.InterfaceRepositories
{
    interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> SelectAll();
        T GetByID(int id);
        void SpecialDelete(int id);
        bool Any(Expression<Func<T, bool>> exp);
        T GetByDefault(Expression<Func<T, bool>> exp);
        int GetLastAddedID();


    }
}
