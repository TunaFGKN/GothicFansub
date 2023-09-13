using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMangaDal : IMangaDal
    {
        public void Add(Manga entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Manga entity)
        {
            throw new NotImplementedException();
        }

        public Manga Get(Expression<Func<Manga, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Manga> GetAll(Expression<Func<Manga, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Manga entity)
        {
            throw new NotImplementedException();
        }
    }
}
