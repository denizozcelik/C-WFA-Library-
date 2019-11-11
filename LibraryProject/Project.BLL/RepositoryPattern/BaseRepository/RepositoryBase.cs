using Project.BLL.RepositoryPattern.InterfaceRepositories;
using Project.DAL.MyContext;
using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.BaseRepository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {

        SContext db = SContext.DBInstance;

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = MODEL.Enums.DataStatus.Deleted;
            db.SaveChanges();
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).FirstOrDefault();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public int GetLastAddedID()
        {
            return db.Set<T>().OrderByDescending(x => x.ID).Take(1).FirstOrDefault().ID;

        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public void SpecialDelete(int id)
        {
            db.Set<T>().Remove(GetByID(id));
            db.SaveChanges();
        }

        public void Update(T item)
        {
            item.Status = MODEL.Enums.DataStatus.Updated;

            T yakalanan = GetByID(item.ID);
            db.Entry(yakalanan).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public List<T> GetActives()
        {
            return db.Set<T>().Where(x => x.Status != MODEL.Enums.DataStatus.Deleted).ToList();
        }

        public T GetActiveID(int id)
        {
            return db.Set<T>().Where(x => x.Status != MODEL.Enums.DataStatus.Deleted && x.ID == id).FirstOrDefault();
        }
    }
}
