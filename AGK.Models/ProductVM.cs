using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace AGK.Models
{
    public class ProductVm
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public double Cost { get; set; }
        public string Image { get; set; }      
    }
}
