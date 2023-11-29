using System.ComponentModel.DataAnnotations;

namespace practiceDB.Model
{
    public class TeacherClass
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }

     
        IList<CoursesClass> Courses { get; set; } 
    }
}
