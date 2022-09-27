using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.DataAccess.Abstract;
using Interface.Entity;

namespace Interface.DataAccess.Concrete
{
                    public class EfProductDal : IProductRepository
                    {
                                        public void Create(Product entity)
                                        {
                                                            throw new NotImplementedException();
                                        }

                                        public void Delete(int id)
                                        {
                                                            throw new NotImplementedException();
                                        }

                                        public Product GetById(int id)
                                        {
                                                            throw new NotImplementedException();
                                        }

                                        public Product[] GetProductsByCategoryId(int id)
                                        {
                                                            throw new NotImplementedException();
                                        }

                                        public void Update(Product entity)
                                        {
                                                            throw new NotImplementedException();
                                        }
                    }
}




