using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Products;

namespace CompanyHierarchy.Interfaces
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
