using IT_Team.Specialization;

namespace IT_Team.Developers;

public record WebDeveloper : Developer
{
    public WebDeveloper(string name, Level level) : base(name, level,DevelopersSpecialization.Web)
    {
    }
}