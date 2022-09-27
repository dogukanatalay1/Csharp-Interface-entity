using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.Entity;

namespace Interface.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        public Category GetById(int id);
       
        public void Update(Category entity);
     
        public void Create(Category entity);

        public void Delete(int id);
      
    }
}




