using System.Drawing;

namespace OOP_Project_3.Core.Entities.Plants;

internal class Grass : Plant {
  public Grass((int, int)position, World world)
      : base(position, world) => Strength = Values.WEAK_STRENGTH;

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.GRASS_TEXT;
    button.ForeColor = Color.WhiteSmoke;
    button.BackColor = Color.FromArgb(34, 139, 34);
  }

  public override void TakeTurn() {
    base.TakeTurn();
    Spread(Values.GRASS_SPREAD_CHANCE);
  }
}
