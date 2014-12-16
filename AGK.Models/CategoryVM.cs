using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGK.Models
{
    public class CategoryVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Root { get; set; }
        public ICollection<CategoryVM> Categories { get; set; }
    }
}
