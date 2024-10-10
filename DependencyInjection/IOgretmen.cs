using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IOgretmen
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }

}
