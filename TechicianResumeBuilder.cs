using CVGenerator_BuilderPattern.Helper;

public class TechnicianResumeBuilder : IResumeBuilder
{
    private Resume resume = new Resume();

    public void SetFirstName()
    {
        Console.Write("Enter your first name: ");
        resume.FirstName = Console.ReadLine();
    }

    public void SetLastName()
    {
        Console.WriteLine("Enter your last name: ");
        resume.LastName = Console.ReadLine();
    }

    public void SetGender()
    {
        Console.WriteLine("Enter your gender: ");
        resume.Gender = Console.ReadLine();
    }

    public void SetAge()
    {
        Console.WriteLine("Enter your age: ");
        resume.Age = Console.ReadLine();
    }

    public void SetEducation()
    {
        Console.Write("Enter your education (e.g. National Certificate in Electrical Engineering): ");
        resume.Education = Console.ReadLine();
    }

    public void SetExperience()
    {
        Console.Write("Enter your years of experience: ");
        resume.Experience = Console.ReadLine();
    }

    public void SetSkills()
    {
        string[] skills = new string[]
        {
            "1. Circuit Testing",
            "2. Diagnostics",
            "3. Equipment Repair",
            "4. Preventive Maintenance",
            "5. Wiring and Cabling",
            "6. Troubleshooting",
            "7. Electrical Safety",
            "8. Blueprint Reading",
            "9. PLC Programming",
            "10. Calibration"
        };
         resume.Skills = SkillSelector.SelectSkills(skills, "General Technical Skills");
    }

    public Resume GetResume() => resume;
}

