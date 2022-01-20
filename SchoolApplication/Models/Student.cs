using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Models
{
    public class Student : NamedEntity
    {
        public string Sex { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
