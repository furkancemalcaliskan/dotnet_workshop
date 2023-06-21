﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void AddBlog(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void DeleteBlog(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetListAll(x => x.BlogId == id);
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public List<Blog> GetBlogListByAuthor(int id)
		{
			return _blogDal.GetListAll(x => x.AuthorId == id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}

		public void UpdateBlog(Blog blog)
		{
			_blogDal.Update(blog);
		}
	}
}
