public class Resume
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Age { get; set; }
    public string Education { get; set; }
    public string Experience { get; set; }
    public string Skills { get; set; }

    public void Display()
    {
        Console.WriteLine("----- Resume -----");
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"LastName: {LastName}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Education: {Education}");
        Console.WriteLine($"Experience: {Experience}");
        Console.WriteLine($"Skills: {Skills}");
    }
}