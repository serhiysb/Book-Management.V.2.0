using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11._2.Core.Interfaces
{
    public interface IGenericUnitOfWork:IDisposable
    {
        public IGenericRepository<T> Repository<T>() where T : class;
        public Task SaveChangesAsync();
    }
}
