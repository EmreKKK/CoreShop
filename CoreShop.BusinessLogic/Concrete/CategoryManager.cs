using CoreShop.BusinessLogic.Abstract;
using CoreShop.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.BusinessLogic.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL= categoryDAL;
        }
    }
}
