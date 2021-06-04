using BootcampHomeWork.Business.Abstract;
using BootcampHomeWork.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampHomeWork.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public IActionResult Index(string query, int categoryId = 0, int page = 1)
        {
            
            var articles = _articleService.GetByCategoryId(categoryId);
            ArticleViewModel model = new ArticleViewModel()
            {
                Articles = articles
                    .ToList(),
                CurrentCategory = categoryId,
                CurrentPage = page
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var article = _articleService.Commented(id);
            DetailModel model = new DetailModel()
            {
                Article = article
            };
            return View(model);
        }
    }
}

