using CoreShop.BusinessLogic.Abstract;
using CoreShop.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.BusinessLogic.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL= productDAL;
        }
    }
}
