using System.Text.Encodings.Web;
using System.Text.Json;
using Edu.models;

namespace EduWestCoast;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("   Westcoast Education");
        Console.WriteLine("--------------------------");

        ManageSchool manageSchool = new ManageSchool();

        Teacher teacher = new Teacher(
            "Hakim",
            "Saleh",
            "+46 76-515 22 74",
            "Ankargatan 23",
            "Göteborg",
            "414 61",
            "Matematik",
            new List<Courses>()
        );
        try { }
        catch (System.Exception)
        {
            throw;
        }
        Courses matematik = new Courses(
            "MA2HT24",
            "Matematik 2B",
            "24 veckor",
            new DateTime(2025, 1, 15),
            new DateTime(2025, 7, 2),
            true,
            "8.5/10"
        );

        List<Courses> coursesList = new List<Courses> { matematik };

        Student patrik = new Student(
            "Patrik",
            "Cederström",
            "+46 72-858 91 23",
            "Tage Madsens väg 9",
            "Partille",
            "433 35",
            "19970214-9112"
        );

        Console.WriteLine("Kursinformation:");
        Console.WriteLine(matematik);
        Console.WriteLine("");

        Console.WriteLine("\nKursens lärare:");
        Console.WriteLine(teacher);
        Console.WriteLine("");

        manageSchool.AddTeacher(teacher);
        Console.WriteLine("");

        manageSchool.AddCourse(matematik);
        Console.WriteLine("");

        manageSchool.AddStudent(patrik);
        Console.WriteLine("");
        Console.WriteLine(patrik);

        EducationManager educationManager = new EducationManager(
            "Linda",
            "Tomassen",
            "+46 73-971 19 00",
            "Folke Filbyters stig 3",
            "Hisings Backa",
            "422 47",
            new DateTime(2012, 2, 17),
            "Pedagogik"
        );

        Console.WriteLine("");
        manageSchool.AddEducationManager(educationManager);

        Console.WriteLine("\nUtbildningsledare:");
        Console.WriteLine(educationManager);
        Console.WriteLine("");

        Administrator administrator = new Administrator(
            "Rosa",
            "Hjorth",
            "+46 73-100 41 38",
            "Brunnsgatan 4B",
            "Mölndal",
            "431 34",
            new DateTime(2024, 3, 4),
            "IT-ansvarig"
        );

        manageSchool.AddAdministrator(administrator);
        Console.WriteLine("\nAdministratör:");
        Console.WriteLine(administrator);

        Console.WriteLine("\nRegistrerade studenter:");
        manageSchool.ListStudents();

        Console.WriteLine("\nTillgängliga kurser:");
        manageSchool.ListCourses();

        teacher.AddCourse(matematik);
        Console.WriteLine("\nLärare:");
        manageSchool.ListTeachers();
        teacher.ListCourses();
        Console.WriteLine("");

        var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

        var json = JsonSerializer.Serialize(coursesList, options);
        var path = string.Concat(Environment.CurrentDirectory, "/Data/courses.json");
        File.WriteAllText(path, json);

        var savedJson = File.ReadAllText(path);
        Console.WriteLine(savedJson);

        options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        var loadedCourse = JsonSerializer.Deserialize<List<Courses>>(savedJson, options);
    }
}
