namespace SchoolManagementApp.MVC.Models
{
    public class DashboardViewModel
    {
        public int TotalStudents { get; set; }
        public int TotalCourses { get; set; }
        public int TotalLecturers { get; set; }

        // Properties for the chart data
        public List<string> ChartLabels { get; set; } = new List<string>();
        public List<int> ChartData { get; set; } = new List<int>();
    }
}