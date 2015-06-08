using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string Name { get; set; }
        DateTime Date { get; set; }
        string Details { get; set; }
        string State { get; set; }
        void CloseProject();
    }
}
