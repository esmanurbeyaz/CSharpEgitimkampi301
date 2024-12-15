using CSharpEgitimkampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 abstract interfaceleri tutar 
interfaceler bütün entitiylerde standart olan bazı methodlar var crud gibi burada tasarım deseni kullanacağız  
 */

namespace CSharpEgitimkampi301.DataAccessLayer.Abstract
{
    public interface IAdmin :  IGenericDal<Admin>
    {
    }
}
