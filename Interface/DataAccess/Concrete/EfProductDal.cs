using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public Product GetById(int id) 
        {
           return new Product();
        }

        public void Update(Product entity)
        {

        }
        public void Create(Product entity)
        {

        }

        public void Delete(int id)
        {

        }

        public Product[] GetProductsByCategoryId(int id)
        {
            return new Product[3];
        }
    };

}




