using IT_Team.Specialization;

namespace IT_Team.Developers;

public record BackendDeveloper : Developer
{
    public BackendDeveloper(string name, Level level) : base(name, level,DevelopersSpecialization.Backend)
    {
    }
}