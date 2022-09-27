using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
      public class EfProductDal
       {
        public Category GetById(int id) 
        {
           return new Category();
        }

        public void Update(Category entity)
        {

        }
        public void Create(Category entity)
        {

        }

        public void Delete(int id)
        {

        }
      };

    }
}




