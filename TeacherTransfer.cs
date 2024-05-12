using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class TeacherTransfer
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }


        public Teacher teacher { get; set; }

        [InverseProperty("leftTeachers")]
        public School fromSchool { get; set; }

        [InverseProperty("comingTeachers")]
        public School toSchool { get; set; }

    }
}
