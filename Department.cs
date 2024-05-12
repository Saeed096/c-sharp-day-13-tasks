using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<School> schools { get; set; }           // navigation prop

    }
}
