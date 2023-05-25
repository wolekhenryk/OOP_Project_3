using System.Drawing;

namespace OOP_Project_3.Core.Entities.Plants;

internal class WilczaJagoda : Plant {
  public WilczaJagoda((int, int)position, World world) : base(position, world) => Strength = 99;

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.NIGHTSHADE_TEXT;
    button.ForeColor = Color.FromArgb(167, 43, 225);
    button.BackColor = Color.FromArgb(138, 226, 43);
  }

  public override void TakeTurn() {
    base.TakeTurn();
    Spread(Values.NIGHTSHADE_SPREAD_CHANCE);
  }
}
