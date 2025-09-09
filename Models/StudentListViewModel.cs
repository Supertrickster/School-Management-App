using SchoolManagementApp.MVC.Data;

namespace SchoolManagementApp.MVC.Models
{
    public class StudentListViewModel
    {
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public int TotalStudents { get; set; }
        public int NewStudentsLast30Days { get; set; }
    }
}