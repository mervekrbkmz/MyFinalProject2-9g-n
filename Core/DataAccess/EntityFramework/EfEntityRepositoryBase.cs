using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
   public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        //entity context tipi verdik.
     //entityframework keullanarak repository base oluştur demek.
        where TEntity:class,IEntity,new()
       where TContext:DbContext,new() 
       //buraya her classı yazamam dbcontexten inherit edilmesi lazım.newledik 
    {
        //core projesine entityframewroku eklemeiz gerekir.nasıl?

        public void Add(TEntity entity)
        {
            //buradaki using:IDisposable pattern implementation of c#
            using (TContext context = new TContext()) //nesneler northwind context  using bitince bellekten atılır.
            {
                var addedEntity = context.Entry(entity);//verikaynağıyla ilişkilendi.refernsı ekle
                addedEntity.State = EntityState.Added; //eklenecek nesne
                context.SaveChanges();//ve ekle kaydet.


            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //nesneler northwind context  using bitince bellekten atılır.
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted; //silinecek nesne
                context.SaveChanges();//ve ekle kaydet.


            }

        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter) //tek data getiricek get.
        {

            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null) //tüm dataları getiricek getall
        {

            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()  //ürünleri listeye çevirdik. filtre nullsa listeleyip ver
                : context.Set<TEntity>().Where(filter).ToList(); //filtre null değilse filtreleyip ver listele.


            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //nesneler northwind context  using bitince bellekten atılır.
            {
                var updatedEntity = context.Entry(entity);//verikaynağıyla ilişkilendi.refernsı ekle
                updatedEntity.State = EntityState.Modified; //güncellenecek nesne
                context.SaveChanges();//ve ekle kaydet.


            }
        }

    }
}
