using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Models.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentDepartment { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public DateTime SutdentSaveDate{ get; set; }
        public int StudentTerm { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<StudentLesson> StudentLesson { get; set; }
    }

}
