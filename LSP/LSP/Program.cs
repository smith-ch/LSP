

namespace MyCourseApp
{
    public class Program
    {
        public static void Main()
        {
            List<Course> courses = new List<Course>
            {
                new OnlineCourse { CourseId = 1, Title = "Online Course 101" },
                new OfflineCourse { CourseId = 2, Title = "Offline Course 101" },
                new HybridCourse { CourseId = 3, Title = "Hybrid Course 101" }
            };

            Student student = new Student { StudentId = 1, Name = "Smith Rodriguez" };

            foreach (var course in courses)
            {
                course.Subscribe(student);
                Console.WriteLine(course.GetCourseDetails());
            }
        }
    }
}
