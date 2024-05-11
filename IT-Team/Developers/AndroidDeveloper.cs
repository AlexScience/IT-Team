using IT_Team.Specialization;

namespace IT_Team.Developers;

public record AndroidDeveloper : Developer
{
    public AndroidDeveloper(string name, Level level) : base(name, level,DevelopersSpecialization.Android)
    {
    }
}