using CVGenerator_BuilderPattern.Helper;

public class NurseResumeBuilder : IResumeBuilder
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
        Console.Write("Enter your education (e.g. Diploma in Nursing): ");
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
            "1. Patient Care",
            "2. CPR",
            "3. Medication Management",
            "4. IV Insertion",
            "5. Wound Care",
            "6. Vital Signs Monitoring",
            "7. Infection Control",
            "8. Emergency Response",
            "9. Health Education",
            "10. Record Keeping"
        };
        resume.Skills = SkillSelector.SelectSkills(skills, "General Nursing Skills");

       
    }

    public Resume GetResume()
    {
        return resume;
    }
}

