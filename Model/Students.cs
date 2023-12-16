using System.ComponentModel.DataAnnotations;

namespace StudentApp.Model
{
    public class Students
    {
        [Key]
        public int StudentKey { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CourseKey { get; set; }
    }
}
