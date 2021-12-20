using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeeBL<TEntity>
    {
        public IEnumerable<Employee> GetAll();
    }
}
