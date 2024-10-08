namespace Edu.models;

public class EducationManager : Teacher
{
    public DateTime EmploymentDate { get; private set; }

    public EducationManager(
        string firstName,
        string lastName,
        string address,
        string phone,
        string city,
        string zipCode,
        DateTime employmentDate,
        string expertise
    )
        : base(firstName, lastName, address, phone, city, zipCode, expertise, new List<Courses>())
    {
        EmploymentDate = employmentDate;
    }

    public override string ToString()
    {
        return $"{base.ToString()} \nEn del av WestCoast sedan: {EmploymentDate.ToShortDateString()}";
    }
}
