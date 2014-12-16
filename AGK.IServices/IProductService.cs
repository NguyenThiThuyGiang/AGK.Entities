using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGK.IServices
{
    public interface IProductService
    {
        IEnumerable<ProductVM> FindByCategory(int category);
        IEnumerable<ProductVM> FindByCategory(int manufactory);
        ProductVM FindById(Guid product);
        IEnumerable<ProductVM> GetRandoms(int category);
        IEnumerable<ProductVM> GetNews(int category);
        IEnumerable<ProductVM> GetNews();
        IEnumerable<ProductVM> GetBestSellers();
        IEnumerable<ProductVM> GetBestSellers(int category);
        bool Add(ProductDetailVM product);
        bool Update(ProductDetailVM product);
        bool Delete(Guid product);

    }
}
