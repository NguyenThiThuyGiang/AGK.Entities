using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGK.IServices;
using AGK.Models;

namespace AGK.Service
{
    public class ProductService : IProductService
    {
        public bool Add(ProductDetail product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> FindByCategory(int category)
        {
            throw new NotImplementedException();
        }

        public ProductVm FindById(Guid product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> FindByManuFacturer(int manufactory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetBestSellers(int category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetBestSellers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetNews()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetNews(int category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetRandoms(int category)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDetail product)
        {
            throw new NotImplementedException();
        }
    }
}
