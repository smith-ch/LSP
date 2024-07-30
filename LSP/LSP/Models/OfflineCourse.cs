using LSP;

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Write code to subscribe to an offline course
    }

    public override string GetCourseDetails()
    {
        return $"Offline Course: {Title} (ID: {CourseId})";
    }
}
