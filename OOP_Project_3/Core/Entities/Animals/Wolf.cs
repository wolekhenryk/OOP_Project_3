using System.Drawing;

namespace OOP_Project_3.Core.Entities.Animals;

internal class Wolf : Animal {
  public Wolf((int, int)position, World world) : base(position, world) {
    Strength = Values.WOLF_STRENGTH;
    Initiative = Values.WOLF_INITIATIVE;
  }

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.WOLF_TEXT;
    button.ForeColor = Color.FromArgb(30, 30, 30);
    button.BackColor = Color.WhiteSmoke;
  }
}
