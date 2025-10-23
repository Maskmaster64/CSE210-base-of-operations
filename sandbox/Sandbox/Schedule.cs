public class Schedule
{

    private Student _student;
    private List<Course> _courses;

    public Schedule(Student student)
    {
        _student = student;
        _courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public Course GetCourse(int index)
    {
        return _courses[index];
    }

    public void Display()
    {
        Console.WriteLine("Schedule");
        
    }
}