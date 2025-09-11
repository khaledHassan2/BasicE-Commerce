using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.GenericInterfaces
{
    public interface IGetAll<TEntity>
    {
         IEnumerable<TEntity>? GetAll();
    }
}
