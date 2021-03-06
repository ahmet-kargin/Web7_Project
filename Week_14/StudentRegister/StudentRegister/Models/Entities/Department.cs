using System.Collections.Generic;

namespace StudentRegister.Models.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentPresident { get; set; }
        public List<Student> Students { get; set; }
    }
}
