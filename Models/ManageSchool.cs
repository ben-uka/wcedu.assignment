using System.Security.Cryptography.X509Certificates;
using EduWestCoast;

namespace Edu.models;

public class ManageSchool
{
    private List<Student> _students { get; set; }
    private List<Teacher> _teachers { get; set; }
    private List<Courses> _courses { get; set; }
    private List<EducationManager> _educationManagers { get; set; }
    private List<Administrator> _administrators { get; set; }

    public ManageSchool()
    {
        _students = new List<Student>();
        _teachers = new List<Teacher>();
        _courses = new List<Courses>();
        _educationManagers = new List<EducationManager>();
        _administrators = new List<Administrator>();
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);

        if (_students.Count > 30)
        {
            Console.WriteLine("Kursen har redan max antal elever.");
        }

        {
            Console.WriteLine(
                $"Elev {student.FirstName} {student.LastName} har lagts till i kursen."
            );
        }

        if (_students.Count < 5)
        {
            Console.WriteLine(
                "Av ekonomiska skäl krävs minst fem anmälda till kursen senast tre veckor innan kursstart."
            );
        }
    }

    public void RemoveStudent(Student student)
    {
        _students.Remove(student);
        Console.WriteLine(
            $"Elev {student.FirstName} {student.LastName} har tagits bort från kursen."
        );
    }

    public void AddTeacher(Teacher teacher)
    {
        _teachers.Add(teacher);
        Console.WriteLine(
            $"Lärare {teacher.FirstName} {teacher.LastName} har lagts till som lärare i kursen."
        );
    }

    public void RemoveTeacher(Teacher teacher)
    {
        _teachers.Remove(teacher);
        Console.WriteLine(
            $"Lärare {teacher.FirstName} {teacher.LastName} har tagits bort från kursen."
        );
    }

    public void AddEducationManager(EducationManager educationManager)
    {
        _educationManagers.Add(educationManager);
        Console.WriteLine(
            $"Utbildningsledare {educationManager.FirstName} {educationManager.LastName} har lagts till."
        );
    }

    public void RemoveEducationManager(EducationManager educationManager)
    {
        _educationManagers.Remove(educationManager);
        Console.WriteLine(
            $"Utbildningsledare {educationManager.FirstName} {educationManager.LastName} har tagits bort."
        );
    }

    public void AddAdministrator(Administrator administrator)
    {
        _administrators.Add(administrator);
        Console.WriteLine(
            $"Administratör {administrator.FirstName} {administrator.LastName} har lagts till."
        );
    }

    public void RemoveAdministrator(Administrator administrator)
    {
        _administrators.Remove(administrator);
        Console.WriteLine(
            $"Administratör {administrator.FirstName} {administrator.LastName} har tagits bort."
        );
    }

    public void AddCourse(Courses courses)
    {
        _courses.Add(courses);
        Console.WriteLine(
            $"Kursen {courses.Title} har lagts till på hemsidan och visas som tillgänglig."
        );
    }

    public void RemoveCourse(Courses course)
    {
        {
            if (_courses.Count == 0)
            {
                Console.WriteLine("Kunde inte ta bort då inga kurser är listade som tillgängliga.");
            }
            _courses.Remove(course);
            Console.WriteLine(
                $"Kursen {course.Title} har nu tagits bort och visas som otillgänglig."
            );
        }
    }

    public void ListCourses()
    {
        foreach (var course in _courses)
            Console.WriteLine(course.Title.ToString());
    }

    public void ListTeachers()
    {
        foreach (var teacher in _teachers)
        {
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName}");
        }
    }

    public void ListStudents()
    {
        foreach (var student in _students)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}
