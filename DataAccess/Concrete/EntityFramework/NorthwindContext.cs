using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{ 

    //burası context kısmıdır.
    //context kısmı: DB tabloları ile projedeki classlar arasında ilişki kurmak.bağlamak.
  public  class NorthwindContext:DbContext //db yi yazarak contexti oluşturmuş olduk.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// projenin hangi veritabanıyla ilişkili olduğunu belirtiğimiz yerdir.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=Northwind;Trusted_Connection=true");
        }
        //DBSET ise hangi classım hangi tabloya bağlandığını bulucaz burdan.
        //hangi tbloya ne karşılık gelir.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Order> Orders{ get; set; }
    }
}
