using CVGenerator_BuilderPattern.Helper;

public class DeveloperResumeBuilder : IResumeBuilder
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
        Console.Write("Enter your education (e.g. BSc in Computer Science): ");
        resume.Education = Console.ReadLine();
    }

    public void SetExperience()
    {
        Console.Write("Enter your years of experience (e.g. 3 years as Full Stack Developer): ");
        resume.Experience = Console.ReadLine();
    }

    public void SetSkills()
    {
        string[] skills = new string[]
        {
            "1. C#", "2. Java", "3. Python", "4. JavaScript", "5. SQL",
            "6. HTML/CSS", "7. React", "8. Angular", "9. .NET Core", "10. Docker"
        };
        
        resume.Skills = SkillSelector.SelectSkills(skills, "General Programming");
        
    }

    public Resume GetResume()
    {
        return resume;
    }
}

