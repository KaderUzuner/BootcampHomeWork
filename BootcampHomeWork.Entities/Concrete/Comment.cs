using BootcampHomeWork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomeWork.Entities.Concrete
{
    public class Comment:IEntity
    {
       
            public int Id { get; set; }
            public string Text { get; set; }
            public int ArticleId { get; set; }
            public Article Article { get; set; }
        
    }
}
