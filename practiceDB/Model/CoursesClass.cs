using System.ComponentModel.DataAnnotations;

namespace practiceDB.Model
{
    public class CoursesClass
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int TeacherID { get; set; }

        public TeacherClass Teacher { get; set; }
    }
}
