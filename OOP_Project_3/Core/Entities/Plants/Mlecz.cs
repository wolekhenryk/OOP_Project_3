using System.Drawing;

namespace OOP_Project_3.Core.Entities.Plants;

internal class Mlecz : Plant {
  public Mlecz((int, int)position, World world)
      : base(position, world) => Strength = Values.WEAK_STRENGTH;

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.MLECZ_TEXT;
    button.ForeColor = Color.DarkGreen;
    button.BackColor = Color.Yellow;
  }

  public override void TakeTurn() {
    base.TakeTurn();
    for (var i = 0; i < Values.MLECZ_ATTEMPTS; i++)
      Spread(Values.MLECZ_SPREAD_CHANCE);
  }
}
