namespace Edu.models;

public class Administrator : EducationManager
{
    public Administrator(
        string firstName,
        string lastName,
        string phone,
        string address,
        string city,
        string zipCode,
        DateTime employmentDate,
        string expertise
    )
        : base(firstName, lastName, phone, address, city, zipCode, employmentDate, expertise) { }

    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}
