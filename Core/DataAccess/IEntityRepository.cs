
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //CORE KATMANI diğer katmanları referans almaz.alırsa sen o katmana bağımlısın demek.

{

 public interface IEntityRepository<T> where T:class,IEntity,new()
    {
     //IEntity:aşağısı için ya ıentity olabilir veya ıentity implemente eden bir nesne olabilir(veritabanı nesnelerimiz)
     //new():newlenebilir olmalı interfacler newlenemez bu yüzden ıentity elemiş olduk.

     //generic constrait:generic kısıt
     //class:referans tip olabilir demek.

     //referans tip olur class.intleri tanımlaamaz.
     //tüm tiplerin yerine T tanımlarız ki her tip yazdığımızda karışıklık olmasın T hepsi için ortak.
     //expression:filtre vermemizi sağlıcak.
 
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//ayrı ayrı metodlar yazmıcaz.//burda filtre vermeyebilirsin.filtre vermezsej tüm datayı isteriz olur. 
        T Get(Expression<Func<T, bool>> filter);//filtre zorunlu burada //TEK Bİ DATA GETİRMEK İÇİN
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    
    }
}
