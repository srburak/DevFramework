using DevFramework.Core.DataAccsess.EntityFramework;
using DevFramework.Core.DataAccsess.NHibernate;
using DevFramework.Core.DataAccsess;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccsess.Abstract;
using DevFramework.Northwind.DataAccsess.Concrete.EntityFramework;
using DevFramework.Northwind.DataAccsess.Concrete.NHibernate.Helppers;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind(typeof(IQueryableReposiyory<>)).To(typeof(EfQueryableReposiyory<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
