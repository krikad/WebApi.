using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Models
{
    public class School : NamedEntity
    {
        public DateTime Created { get; set; }
        public List<Student> Students { get; set; }
    }
}
