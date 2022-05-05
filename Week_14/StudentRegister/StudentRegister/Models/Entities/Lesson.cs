using System.Collections.Generic;

namespace StudentRegister.Models.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonTeacher { get; set; }
        public decimal Credit { get; set; }
        public int LessonTerm { get; set; }
        public List<StudentLesson> StudentLesson { get; set; }
    }
}
