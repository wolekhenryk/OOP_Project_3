using System.Drawing;

namespace OOP_Project_3.Core.Entities.Plants;

internal class Sosnowski : Plant {
  public Sosnowski((int, int)position, World world)
      : base(position, world) => Strength = Values.BARSZCZ_STRENGTH;

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.BARSZCZ_TEXT;
    button.ForeColor = Color.Black;
    button.BackColor = Color.WhiteSmoke;
  }

  public override void TakeTurn() {
    base.TakeTurn();
    Spread(Values.BARSZCZ_SPREAD_CHANCE);
  }
}
