using System.Drawing;

namespace OOP_Project_3.Core.Entities.Plants;

internal class Guarana : Plant {
  public Guarana((int, int)position, World world)
      : base(position, world) => Strength = Values.WEAK_STRENGTH;

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.GUARANA_TEXT;
    button.ForeColor = Color.YellowGreen;
    button.BackColor = Color.DarkOrange;
  }

  public override void TakeTurn() {
    base.TakeTurn();
    Spread(Values.GUARANA_SPREAD_CHANCE);
  }

  public override void TakeEffect(Animal eater) {
    base.TakeEffect(eater);
    eater.Empower(Values.GUARANA_POWER);
    WorldRef.Message($"{eater.GetType().Name} was empowered, current strength: {eater.Strength}");
  }
}
