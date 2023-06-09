﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x=>x.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByAuthor(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x=>x.Category).Where(x=>x.AuthorId == id).ToList();
            }
        }
    }
}
