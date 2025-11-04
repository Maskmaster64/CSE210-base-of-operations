public class Student : Person
{
    private string _id;

    public Student(string name, string id) : base(name)
    {
        _id = id;
    }
}