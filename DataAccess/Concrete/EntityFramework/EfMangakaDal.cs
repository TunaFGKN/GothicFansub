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
    public class EfMangakaDal : IMangakaDal
    {
        public void Add(Mangaka entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Mangaka entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Mangaka Get(Expression<Func<Mangaka, bool>> filter)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                return context.Set<Mangaka>().SingleOrDefault(filter);
            }
        }

        public List<Mangaka> GetAll(Expression<Func<Mangaka, bool>> filter = null)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                return filter == null ? context.Set<Mangaka>().ToList() : context.Set<Mangaka>().Where(filter).ToList();
            }
        }

        public void Update(Mangaka entity)
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
