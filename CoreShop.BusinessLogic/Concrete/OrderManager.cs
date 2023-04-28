using CoreShop.BusinessLogic.Abstract;
using CoreShop.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.BusinessLogic.Concrete
{
    public class OrderManager:IOrderService
    {
        private IOrderDAL _orderDAL;
        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL= orderDAL;
        }
    }
}
