using System.Text.Json.Serialization;

namespace Edu.models;

public class Courses
{
    public string CourseNumber { get; private set; } = "";
    public string Title { get; private set; } = "";
    public string CourseLength { get; private set; } = "";
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public string? StudentsRating { get; private set; }
    public bool IsOnSite { get; set; }

    public Courses(
        string courseNumber,
        string title,
        string courseLength,
        DateTime startDate,
        DateTime endDate,
        bool isOnSite,
        string studentsRating
    )
    {
        CourseNumber = courseNumber;
        Title = title;
        CourseLength = courseLength;
        StartDate = startDate;
        EndDate = endDate;
        IsOnSite = isOnSite;
        StudentsRating = studentsRating;
    }

    public override string ToString()
    {
        string courseType = IsOnSite ? "På plats" : "Distans";
        return $"\n{Title} — {CourseNumber} \nKurslängd: {CourseLength} \nStartdatum: från {StartDate.ToString("yyyy-MM-dd")} till preliminärt slutdatum {EndDate.ToString("yyyy-MM-dd")}. \nKurstyp: {courseType} \nElevernas betygsättning av kursen: {StudentsRating}";
    }
}
