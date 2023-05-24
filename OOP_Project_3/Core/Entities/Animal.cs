using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_3.Core.Entities {
  internal class Animal : Organism {
    public Animal((int, int)position, World world) : base(position, world) {}

    public override void TakeTurn() {
      base.TakeTurn();

      var newPos = WorldRef.NextMove(Position);
      if (newPos == Position)
        return;

      var foundOrganism = WorldRef.OrganismAtPosition(newPos);
      if (foundOrganism != null)
        Collision(foundOrganism);
      else
        Position = newPos;
    }

    public override void Display() {}

    private bool SameSpecies(Animal other) => GetType().Name == other.GetType().Name;

    private void Reproduce() {
      WorldRef.Message($"{GetType().Name} reproducing");
      var newPos = WorldRef.FindFreeSpot(Position);

      if (newPos != (0, 0))
        WorldRef.AddOrganism(OrganismFactory.Create(GetType(), newPos, WorldRef));
    }
    public override void Collision(Organism other) {
      if (other is not Animal animal)
        return;
      if (SameSpecies(animal))
        Reproduce();
      else
        Fight(animal);
    }

    protected void Fight(Animal other) {
      var compareResult = Strength.CompareTo(other.Strength);
      switch (compareResult) {
        case < 0:
          Die();
          other.Position = Position;
          WorldRef.Message(
              $"{other.GetType().Name} mercilessly murdered {GetType().Name} at [{Position.Item1}, {Position.Item2}]");
          break;
        case > 0:
          other.Die();
          Position = other.Position;
          WorldRef.Message(
              $"{GetType().Name} mercilessly murdered {other.GetType().Name} at [{other.Position.Item1}, {other.Position.Item2}]");
          break;
      }
    }
  }
}
