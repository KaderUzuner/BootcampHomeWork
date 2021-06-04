using BootcampHomeWork.Business.Abstract;
using BootcampHomeWork.DataAccess.Abstract;
using BootcampHomeWork.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomeWork.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<Article> GetAll()
        {
            return _articleDal.GetAll();
        }

        public List<Article> GetByCategoryId(int categoryId)
        {
            return _articleDal.GetAll(c => c.CategoryId == categoryId || categoryId == 0);
        }

        public Article Get(int id)
        {
            return _articleDal.Get(a => a.Id == id);
        }

        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void Update(Article article)
        {
            _articleDal.Update(article);
        }

        public void Delete(Article article)
        {
            _articleDal.Delete(article);
        }

        public Article Commented(int id)
        {
            throw new NotImplementedException();
        }
    }
}
