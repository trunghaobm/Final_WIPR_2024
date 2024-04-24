using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public enum Role
    {
        None, Admin, Student, Lecturer
    }

    public class Permission
    {

        public Enum Role { get; set; } = Source.Role.Admin;

        public Permission() { }
    }
}
