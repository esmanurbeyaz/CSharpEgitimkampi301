using CSharpEgitimkampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimkampi301.DataAccessLayer.Abstract
{
    public interface IProductDal :  IGenericDal <Product>
    {
        List<Object> GetProductsWithCategory();
    }
}
