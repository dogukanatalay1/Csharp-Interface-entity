using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.DataAccess.Abstract
{
    public interface IProductRepository
    {
        public Product GetById(int id);

        public void Update(Product entity);
      
        public void Create(Product entity);
     
        public void Delete(int id);  

        public Product[] GetProductsByCategoryId(int id);
      
    }
}



