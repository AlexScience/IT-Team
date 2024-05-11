using IT_Team.Engineers;
using IT_Team.Specialization;

namespace IT_Team.Developers;

public record Developer : Engineer
{
    public DevelopersSpecialization Specialization { get; set; }

    public Developer(string name, Level level, DevelopersSpecialization specialty) : base(name, level)
    {
        Specialization = specialty;
    }
}