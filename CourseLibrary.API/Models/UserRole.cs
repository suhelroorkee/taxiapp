using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
    }
}
