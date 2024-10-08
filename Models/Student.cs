namespace Edu.models;

public class Student : PersonalData
{
    public string? PersonalIdentityNumber { get; private set; }

    public Student(
        string firstName,
        string lastName,
        string phone,
        string address,
        string city,
        string zipCode,
        string personalIdentityNumber
    )
        : base(firstName, lastName, phone, address, city, zipCode)
    {
        PersonalIdentityNumber = personalIdentityNumber;
    }

    public override string ToString()
    {
        return $"{base.ToString()} \nPersonnummer: {PersonalIdentityNumber}";
    }
}
