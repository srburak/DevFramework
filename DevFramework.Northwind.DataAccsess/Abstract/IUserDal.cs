using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccsess;
using DevFramework.Northwind.Entities.ComplexTyps;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccsess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
