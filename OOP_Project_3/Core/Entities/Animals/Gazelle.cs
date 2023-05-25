using System.Drawing;

namespace OOP_Project_3.Core.Entities.Animals;

internal class Gazelle : Animal {
  public Gazelle((int, int)position, World world) : base(position, world) {
    Strength = Values.GAZELLE_STRENGTH;
    Initiative = Values.GAZELLE_INITIATIVE;
  }

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.GAZELLE_TEXT;
    button.ForeColor = Color.WhiteSmoke;
    button.BackColor = Color.FromArgb(60, 82, 45);
  }

  public override void TakeTurn() {
    var newPos = WorldRef.NextMove(Position, Values.GAZELLE_FACTOR);
    if (newPos.Equals(Position))
      return;

    var foundOrganism = WorldRef.OrganismAtPosition(newPos);
    if (foundOrganism != null)
      Collision(foundOrganism);
    else
      Position = newPos;
  }

  protected override bool DefendItself(Animal other) =>
      WorldRef.GetRandomNumber(0, Values.GAZELLE_FACTOR) == 0;
}
