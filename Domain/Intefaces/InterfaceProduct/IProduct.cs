
using Domain.Intefaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Intefaces.InterfaceProduct
{
    public class IProduct : IGeneric<Produto>
    {
        public Task Add(Produto Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Produto Objeto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(Produto Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
