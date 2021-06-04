using BootcampHomeWork.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampHomeWork.Mvc.Models
{
    public class CategoryViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
    }
}

