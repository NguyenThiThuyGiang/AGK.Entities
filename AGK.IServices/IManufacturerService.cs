using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGK.IServices
{
    public interface IManufacturerService
    {
        ICollection<ManufacturerVM> Gets();
        bool Add(ManufacturerVM manufacturer);
        bool Update(ManufacturerVM manufacturer);
        bool Delete(int manufacturer);

    }
}
