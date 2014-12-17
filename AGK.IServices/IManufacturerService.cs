using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGK.Models;

namespace AGK.IServices
{
    public interface IManufacturerService
    {
        ICollection<ManufacturerVm> Gets();
        bool Add(ManufacturerVm manufacturer);
        bool Update(ManufacturerVm manufacturer);
        bool Delete(int manufacturer);

    }
}
