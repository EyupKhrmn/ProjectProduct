using System.Collections.Generic;
using DataAccessLayer.Concrate;
using EntityLayer.Entities;

namespace BusinessLayer.Manager
{
    public class ProductManager
    {
        private Repository<Product> proRepository = new Repository<Product>();

        public List<Product> GetAll()
        {
           return proRepository.List();
        }

        public int BusAdd(Product p)
        {
            if (p.Name.Length <= 3)
            {
                return -1;
            }

            return proRepository.Insert(p);
        }

        public List<Product> GetByName(string p)
        {
            return proRepository.List(x => x.Name == p);
        }
    }
}