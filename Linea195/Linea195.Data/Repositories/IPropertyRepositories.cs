using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linea195.Model;

namespace Linea195.Data.Repositories
{
    public interface IPropertyRepositories
    {
        Task<IEnumerable<Propertys>> GetProperty();
        Task<bool> InsertProperty(Propertys Propertys);

        Task<bool> InsertImage(Propertys Propertys);

        Task<bool> UpdateProperty(Propertys propertys);

        Task<bool> UpdatePrice(Propertys propertys);
    }
}
