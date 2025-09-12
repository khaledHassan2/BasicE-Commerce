using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.InfraStructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BasicEcommerceDbContext _Context;
        public UnitOfWork(BasicEcommerceDbContext Context)
        {
            _Context = Context;
        
        }
        public int Commit()
        {
            return _Context.SaveChanges();
        }
        public void Dispose()
        {
            this._Context.Dispose();
        }
    }
}
