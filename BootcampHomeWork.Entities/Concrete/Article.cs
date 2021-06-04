using BootcampHomeWork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomeWork.Entities.Concrete
{
    public class Article :IEntity
    {
        public Article()
        {
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
 
 


