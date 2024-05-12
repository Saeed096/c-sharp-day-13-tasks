using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Teacher
    {
        public int Id { get; set; }
        public int schoolId { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public int NID { get; set; }
        public int code { get; set; }
        public string job { get; set; }
        public int phone { get; set; }
        public string qualification { get; set; }
        public DateTime qualificationDate { get; set; }
        public DateTime hiringDate { get; set; }
        public string address { get; set; }
        public string notes { get; set; }


        public School school { get; set; }

    }
}
