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
    public class EfMangaDal : IMangaDal
    {
        public void Add(Manga entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var addedEntity = context.Entry(entity); 
                addedEntity.State = EntityState.Added;  
                context.SaveChanges(); 
            }
        }

        public void Delete(Manga entity)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Manga Get(Expression<Func<Manga, bool>> filter)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                return context.Set<Manga>().SingleOrDefault(filter);
            }
        }

        public List<Manga> GetAll(Expression<Func<Manga, bool>> filter = null)
        {
            using (FansubDBContext context = new FansubDBContext())
            {
                return filter == null ? context.Set<Manga>().ToList() : context.Set<Manga>().Where(filter).ToList();
            }
        }

        public void Update(Manga entity)
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
