using BootcampHomeWork.Core.DataAccess;
using BootcampHomeWork.DataAccess.Abstract;
using BootcampHomeWork.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomeWork.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepository<Category, HomeWorkContext>, ICategoryDal
    {
    }
}
