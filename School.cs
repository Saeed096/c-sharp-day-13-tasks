using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ICollection<Teacher> teachers { get; set; }           // navigation prop

        [InverseProperty("fromSchool")]
        public ICollection<TeacherTransfer> leftTeachers { get; set; }           // navigation prop

        [InverseProperty("toSchool")]
        public ICollection<TeacherTransfer> comingTeachers { get; set; }           // navigation prop


    }
}
