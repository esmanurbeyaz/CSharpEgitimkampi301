using CSharpEgitimkampi301.DataAccessLayer.Abstract;
using CSharpEgitimkampi301.DataAccessLayer.Repositories;
using CSharpEgitimkampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimkampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin> , IAdminv 
    {
    }
}
