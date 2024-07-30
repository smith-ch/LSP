using LSP;

public class HybridCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Write code to subscribe to a hybrid course
    }

    public override string GetCourseDetails()
    {
        return $"Hybrid Course: {Title} (ID: {CourseId})";
    }
}
