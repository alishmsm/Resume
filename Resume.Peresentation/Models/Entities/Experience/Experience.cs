namespace Resume.Peresentation.Models.Entities.Experience;

public class Experience
{
    public int Id { get; set; }
    public string ExperienceTitle { get; set; }
    public string ExperienceDuration { get; set; }
    public string ExperienceDecription { get; set; }
    public string CompanyName { get; set; }
    public string? CompanySite { get; set; }

}