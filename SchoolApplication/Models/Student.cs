using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Models
{
    public class Student : NamedEntity
    {
        public int SchoolId { get; set; }
        public School School { get; set; }
        public Sex Sex { get; set; }
        public int SexId { get; set; }
    }
}
