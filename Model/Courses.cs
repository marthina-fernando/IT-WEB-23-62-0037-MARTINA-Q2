using System.ComponentModel.DataAnnotations;

namespace StudentApp.Model
{
    public class Courses
    {
        [Key]
        public int CourseKey { get; set; }
        public string Name { get; set; }
        public string LectureName { get; set; }

    }
}
