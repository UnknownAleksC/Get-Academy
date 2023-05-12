namespace Social_Media;

public class User
{   
    // Egenskaper som beskriver objektet
    public string UserName { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string Description { get; set; }

    // Constructor for å få start verdiene

    public User() { }

    public User(string username, int age, string occupations, string description)
    {
        UserName = username;
        Age = age;
        Occupation = occupations;
        Description = description;
    }

    // Funksjoner
    public void AddName(string name)
    {
        UserName = name;
    }
}