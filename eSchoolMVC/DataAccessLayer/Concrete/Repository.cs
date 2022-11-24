using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        public int Add(T ent)
        {
            c.Add(ent);
            return c.SaveChanges();
        }

        public int Delete(T ent)
        {
            c.Remove(ent);
            return c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T getByID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public int Update(T ent)
        {
            c.Update(ent);
            return c.SaveChanges();
        }
    }
}
