using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.absract;
using entities.concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.concrete.EntityFrameWork
{
    public class EfCategoryDal : ICategoryDal
    {
        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (DbContext context = new NorthwindContext())
            {
                return filter == null ?
                       context.Set<Category>().ToList():
                context.Set<Category>().Where(filter).ToList();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (DbContext context = new NorthwindContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public void Add(Category entity)
        {
            using (DbContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                
            }
        }

        public void Delete(Category entity)
        {
            using (DbContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public void Update(Category entity)
        {
            using (DbContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
