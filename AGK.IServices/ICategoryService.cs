using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGK.IServices
{
    public interface ICategoryService
    {
        ICollection<CategoryVM> Gets();
        bool Add(CategoryVM category);
        bool Update(CategoryVM category);
        bool Delete(int category);

    }
}
