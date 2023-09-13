using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGenreDal : IGenreDal
    {
        public void Add(Genre entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Genre entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Genre Get(Expression<Func<Genre, bool>> filter)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                return context.Set<Genre>().SingleOrDefault(filter);
            }
        }

        public List<Genre> GetAll(Expression<Func<Genre, bool>> filter = null)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                return filter == null ? context.Set<Genre>().ToList() : context.Set<Genre>().Where(filter).ToList();
            }
        }

        public void Update(Genre entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
