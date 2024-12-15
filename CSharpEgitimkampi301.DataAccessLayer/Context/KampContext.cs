using CSharpEgitimkampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
context -> code first projelerinde veri tabanı bağlamtı adresimixi tuttuğumuz ve veri tabanına yansıyacak olan tabloları tuttuğumuz bir sınıf görevi görür

 */

namespace CSharpEgitimkampi301.DataAccessLayer.Context
{
    public class KampContext:DbContext
    {
        public DbSet <Category> Categories { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
