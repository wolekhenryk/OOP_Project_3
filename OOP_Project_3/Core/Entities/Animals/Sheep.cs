using System.Drawing;

namespace OOP_Project_3.Core.Entities.Animals;

internal class Sheep : Animal {
  public Sheep((int, int)position, World world) : base(position, world) {
    Strength = Values.SHEEP_STRENGTH;
    Initiative = Values.SHEEP_INITIATIVE;
  }

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.SHEEP_TEXT;
    button.ForeColor = Color.GhostWhite;
    button.BackColor = Color.DarkGray;
  }
}
