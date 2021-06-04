using BootcampHomeWork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomeWork.Entities.Concrete
{
    public class Category :IEntity
    {
        public Category()
        {
            Articles = new List<Article>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
