using IT_Team.Specialization;

namespace IT_Team.Developers;

public record IosDeveloper : Developer
{
    public IosDeveloper(string name, Level level) : base(name, level,DevelopersSpecialization.iOS)
    {
    }
}