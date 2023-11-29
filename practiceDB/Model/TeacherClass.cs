namespace practiceDB.Model
{
    public class TeacherClass
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }

     
        IList<CoursesClass> Courses { get; set; } 
    }
}
