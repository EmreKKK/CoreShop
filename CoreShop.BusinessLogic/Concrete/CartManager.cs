using CoreShop.BusinessLogic.Abstract;
using CoreShop.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.BusinessLogic.Concrete
{
    public class CartManager : ICartService
    {
        private ICartDAL _cartDAL;

        public CartManager(ICartDAL cartDAL)
        {
            _cartDAL= cartDAL;
        }
    }
}
