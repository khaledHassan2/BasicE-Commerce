using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.GenericInterfaces
{
    public interface IGetItembyId<TEntity,TKey>
    {
         TEntity? GetItemById(TKey id);
    }
}
