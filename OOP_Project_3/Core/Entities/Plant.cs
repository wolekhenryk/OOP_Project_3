namespace OOP_Project_3.Core.Entities;

internal abstract class Plant : Organism {
  protected Plant((int, int)position, World world)
      : base(position, world) => Initiative = Values.PLANT_INITIATIVE;

  protected void Spread(int chancePercent) {
    var randomNumber = WorldRef.GetRandomNumber(0, 100);
    if (randomNumber > chancePercent)
      return;

    var newPosition = WorldRef.NextMove(Position);
    if (newPosition == default)
      return;

    WorldRef.AddOrganism(OrganismFactory.Create(GetType(), newPosition, WorldRef));
  }

  public virtual void TakeEffect(Animal eater) {
    if (Strength > eater.Strength) {
      eater.Die();
      Die();
      WorldRef.Message($"{eater.GetType().Name} was poisoned by {GetType().Name}");
    } else {
      Die();
      eater.Position = Position;
      WorldRef.Message($"{eater.GetType().Name} ate {GetType().Name}");
    }
  }
}
