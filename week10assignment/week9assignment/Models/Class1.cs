using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week9assignment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string UrlPath { get; set; }
        public virtual string Bio { get; set; }
        public virtual string PhotoUrl { get; set; }

    }
}