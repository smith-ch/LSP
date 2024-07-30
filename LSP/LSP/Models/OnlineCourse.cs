using LSP;

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Write code to subscribe to an online course
    }

    public override string GetCourseDetails()
    {
        return $"Online Course: {Title} (ID: {CourseId})";
    }
}
