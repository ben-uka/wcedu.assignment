using System.Runtime.CompilerServices;

namespace Edu.models;

public class Teacher : PersonalData
{
    public string Expertise { get; private set; }
    public List<Courses> Courses { get; private set; }

    public Teacher(
        string firstName,
        string lastName,
        string address,
        string phone,
        string city,
        string zipCode,
        string expertise,
        List<Courses> courses
    )
        : base(firstName, lastName, address, phone, city, zipCode)
    {
        Expertise = expertise;
        Courses = courses;
    }

    public void AddCourse(Courses course)
    {
        Courses.Add(course);
    }

    public void RemoveCourse(Courses course)
    {
        Courses.Remove(course);
    }

    public void ListCourses()
    {
        if (Courses.Count == 0)
        {
            Console.WriteLine(" — Inga registrerade kurser för tillfället.");
        }
        foreach (var course in Courses)
        {
            Console.WriteLine("Kurser: " + course.Title);
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()} \nKunskapsområde: {Expertise}";
    }
}
