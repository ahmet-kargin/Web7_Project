using StudentRegister.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public DateTime SutdentSaveDate { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
