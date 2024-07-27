using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccsess
{
    public interface IQueryableReposiyory<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
