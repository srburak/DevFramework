using DevFramework.Core.DataAccsess.EntityFramework;
using DevFramework.Northwind.DataAccsess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccsess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntitiyRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
