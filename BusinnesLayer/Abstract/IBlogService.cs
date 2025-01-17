﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetList();
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogByCategory(int id);
        List<Blog> GetBlogByDate();
        List<Blog> GetBlogByRating();
        List<Blog> GetBlogByStatus();
        List<Blog> GetListBlogByWriter(int id);
        void BlogAdd(Blog blog);
        Blog GetByID(int id);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
    }
}
