using System.Collections.Generic;
using DataAccessLayer.Concrate;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BusinessLayer.Manager
{
    public class CategoryManager
    {
        private Repository<Category> cateRepository = new Repository<Category>();

        public List<Category> GetAll()
        {
            return cateRepository.List();
        }

        public int BusAdd(Category c)
        {
            if (c.Name.Length <= 3)
            {
                return -1;
            }

            return cateRepository.Insert(c);
        }

        public int BusDelete(int p)
        {
            if (p != 0)
            {
                Category c = cateRepository.Find(x => x.CategoryId == p);
                return cateRepository.Delete(c);
            }
            else
            {
                return -1;
            }
        }

        public int BusUpdate(Category p)
        {
            if (p.Name == " " || p.Name.Length<= 3 || p.Name.Length >= 30)
            {
                return -1;
            }
            else
            {
                Category ct = cateRepository.Find(x => x.CategoryId == p.CategoryId);
                ct.Name = p.Name;
                return cateRepository.Update(ct);
            }
        }
    }
}