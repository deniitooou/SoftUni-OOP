namespace Raiding.Models.Contracts
{
    public interface IHero
    {
        public string Name { get; set; }

        public int Power { get; set; }

        public string CastAbility();
    }
}