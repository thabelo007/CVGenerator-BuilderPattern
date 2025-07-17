class Program
{
    static void Main()
    {
        Console.WriteLine("Choose resume type:");
        Console.WriteLine("1. Developer");
        Console.WriteLine("2. Nurse");
        Console.WriteLine("3. Technician");
        Console.Write("Enter choice (1-3): ");

        string choice = Console.ReadLine();
        IResumeBuilder builder;

        switch (choice)
        {
            case "1":
                builder = new DeveloperResumeBuilder();
                break;
            case "2":
                builder = new NurseResumeBuilder();
                break;
            case "3":
                builder = new TechnicianResumeBuilder();
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Developer.");
                builder = new DeveloperResumeBuilder();
                break;
        }

        ResumeDirector director = new ResumeDirector(builder);
        director.BuildResume();
        Resume resume = director.GetResume();

        Console.ForegroundColor = ConsoleColor.Green;
        resume.Display();
        Console.ResetColor();
    }
}
