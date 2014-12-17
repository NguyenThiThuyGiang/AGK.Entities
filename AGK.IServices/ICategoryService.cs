using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGK.Models;

namespace AGK.IServices
{
    public interface ICategoryService
    {
        ICollection<CategoryVm> Gets();
        bool Add(CategoryVm category);
        bool Update(CategoryVm category);
        bool Delete(int category);

    }
}
