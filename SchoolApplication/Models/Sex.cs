﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Models
{
    public class Sex : NamedEntity
    {
        public List<Student> Students { get; set; }
    }
}
