using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*concrete : c# ta somut ifadeler için kullanılan bir klasör yanı sınıflar için 
        access modifiers
         -public -> her yerden erişim var 
         -private -> sadece bulunduğu classtan interface den erişim sağlanabilir
         -internale -> sadece bulunduğu katmandan erişim sağlanabilir
         -protected -> bir sınıf ve o sınıfı miras alan yerlerden erişim sağlanır
        bunlar erişim belirleyicidir. erişim belirleyiciler : oluşturduğumuz sınıfın interface in kimler tarafından erişilebileceğini belirleyen ve uygun kısıtlamayı koyan yapı.
       */

// code first kullanacağız : c# taki sınıfları alır ve sqlde tablo oluşturur

/*
 Field  int x;
 variable void test() 
          {
             int x;
          }   
 property int x { get; set; }


field -> class içinde direkt tanımlanmışsa
property -> class içinde get set olarak tanımlanmışsa
variable ->  method içinde tanımlanıyorsa
 */

namespace CSharpEgitimkampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } //haber ettik burası çoğul ilişki
        //bire çok code first
    }
}
