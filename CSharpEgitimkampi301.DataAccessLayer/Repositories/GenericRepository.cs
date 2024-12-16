using CSharpEgitimkampi301.DataAccessLayer.Abstract;
using CSharpEgitimkampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimkampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class //T için IGeneric den miras alacaksın ve şartımız T mutlaka bir class olacak
    {
        KampContext context = new KampContext(); //KampContext sınıfından bi tane context nesnesi türettim
        private readonly DbSet<T> _object; //db set türünde içine T değeri alan adı _object olan olam bir field örnekledik 

        public GenericRepository() //ctor yaz
        {
            _object = context.Set<T>(); // generic çağırıldığı anda contextten gelen set T değerini _object e ata
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted; //EntityStat crud işlemleri ve başka komutlara izin veren bir kod bloğu
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var editedEntity = context.Entry(entity);
            editedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
