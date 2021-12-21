using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string token { get; set; }
        public DateTime LastActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
