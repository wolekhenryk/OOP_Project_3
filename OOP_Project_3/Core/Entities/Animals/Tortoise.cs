using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_3.Core.Entities.Animals {
  internal class Tortoise : Animal {
    public Tortoise((int, int)position, World world) : base(position, world) {
      Strength = Values.TORTOISE_STRENGTH;
      Initiative = Values.TORTOISE_INITIATIVE;
    }

    public override void Display() {
      var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
      button.Text = Values.TORTOISE_TEXT;
      button.ForeColor = Color.FromArgb(155, 204, 102);
      button.BackColor = Color.FromArgb(51, 51, 51);
    }

    public override void TakeTurn() {
      var randomNumber = WorldRef.GetRandomNumber(0, Values.SQUARE_MOVES);
      if (randomNumber > Values.TORTOISE_MOVE_CHANCE)
        base.TakeTurn();
    }

    public override void Collision(Organism other) {
      if (other.Strength < 5)
        return;
      base.Collision(other);
    }
  }
}
