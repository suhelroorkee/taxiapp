using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleTitle { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
