public class ResumeDirector
{
    private IResumeBuilder builder;

    public ResumeDirector(IResumeBuilder builder)
    {
        this.builder = builder;
    }

    public void BuildResume()
    {
        builder.SetFirstName();
        builder.SetLastName();
        builder.SetGender();
        builder.SetAge();
        builder.SetEducation();
        builder.SetExperience();
        builder.SetSkills();
    }

    public Resume GetResume()
    {
        return builder.GetResume();
    }
}