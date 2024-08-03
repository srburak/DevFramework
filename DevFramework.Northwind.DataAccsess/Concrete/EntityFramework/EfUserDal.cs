using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccsess.EntityFramework;
using DevFramework.Northwind.DataAccsess.Abstract;
using DevFramework.Northwind.Entities.ComplexTyps;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccsess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntitiyRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from r in context.Roles 
                    join ur in context.UserRoles on r.Id equals ur.RoleId where ur.UserId == user.Id 
                    select new UserRoleItem { RoleName = r.Name };
                return result.ToList();
            }
        }
    }
}
