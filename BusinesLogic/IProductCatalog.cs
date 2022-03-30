using DomainLayer.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public interface IProductCatalog
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        IEnumerable<Product> GetAll();
        void GetById(int Id);
    }
}
