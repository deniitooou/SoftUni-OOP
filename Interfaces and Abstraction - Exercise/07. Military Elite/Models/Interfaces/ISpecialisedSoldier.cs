namespace MilitaryElite.Models.Interfaces
{
    using MilitaryElite.Models.Enums;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
