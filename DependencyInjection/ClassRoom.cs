using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClassRoom
    {
        public IOgretmen Teacher { get; }

        // Constructor Injection ile Teacher nesnesi ClassRoom'a veriliyor
        public ClassRoom(IOgretmen teacher)
        {
            Teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return Teacher.GetInfo();
        }
    }

}
