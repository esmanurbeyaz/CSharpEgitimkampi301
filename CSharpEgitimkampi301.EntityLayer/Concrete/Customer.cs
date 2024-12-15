using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 SOLİD :
single responsibility : tek sorumluluk ilkesi -> bir method bir sınıf 
bir interface ya da başka bir bileşen bağlı bulunduğu alanda tek bir işlem yapmalı
 */

namespace CSharpEgitimkampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId{ get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
