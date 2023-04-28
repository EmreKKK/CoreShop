using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.Entities
{
    public class ProductCategory

    //Çift taraflı çoka çok ilişki için kurulan bir entity. ikili Id sistemi var. Bu yüzden context class'ının içerisine OnModelCreating methodu override edilerek çift id tanımlandı !!!!!!
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
