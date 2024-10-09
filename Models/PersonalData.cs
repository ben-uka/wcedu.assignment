using Edu.models;

namespace Edu.models;

public class PersonalData : IPerson
{
    public string Address { get; protected set; }
    public string City { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string Phone { get; protected set; }
    public string ZipCode { get; protected set; }

    public PersonalData(
        string firstName,
        string lastName,
        string phone,
        string address,
        string city,
        string zipCode
    )
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Address = address;
        City = city;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"Namn: {FirstName} {LastName} \nTelefonnummer: {Phone} \nAdress: {Address} \n{City} {ZipCode}";
    }
}
