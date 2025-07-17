namespace CVGenerator_BuilderPattern.Helper
{
    public static class SkillSelector
    {
        public static string SelectSkills(string[] skills, string defaultSkill)
        {
            Console.WriteLine("Select skills from the list below:");
            foreach (var skill in skills)
            {
                Console.WriteLine(skill);
            }

            Console.WriteLine("Enter the numbers of the skills you have (Comma-separated, e.g., 1,3,5)");

            string input = Console.ReadLine();

            var selectedIndices = input.Split(',')
            .Select(s => s.Trim())
            .Where(s => int.TryParse(s, out _))
            .Select(int.Parse)
            .Where(i => i >= 1 && i <= skills.Length)
            .ToList();

            if (selectedIndices.Count == 0)
            {
                Console.WriteLine($"No valid skills selected. Defaulting to '{defaultSkill}'");
                return defaultSkill;
            }

            return string.Join(", ", selectedIndices.Select(i => skills[i - 1].Substring(3)));

        }

    }
}