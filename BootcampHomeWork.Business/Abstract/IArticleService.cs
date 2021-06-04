using BootcampHomeWork.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomeWork.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetAll();
        List<Article> GetByCategoryId(int categoryId);
        Article Commented(int id);
        Article Get(int id);
        void Delete(Article article);
        void Update(Article article);
        void Add(Article article);
    }
}

