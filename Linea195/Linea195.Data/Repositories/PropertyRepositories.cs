using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linea195.Model;

namespace Linea195.Data.Repositories
{
    class PropertyRepositories : IPropertyRepositories
    {
        public Task<IEnumerable<Propertys>> GetProperty()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertImage(Propertys Propertys)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProperty(Propertys Propertys)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(Propertys propertys)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProperty(Propertys propertys)
        {
            throw new NotImplementedException();
        }
    }
}
