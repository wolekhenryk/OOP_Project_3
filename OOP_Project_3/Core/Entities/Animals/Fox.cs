using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_3.Core.Entities.Animals {
  internal class Fox : Animal {
    public Fox((int, int)position, World world) : base(position, world) {
      Strength = Values.FOX_STRENGTH;
      Initiative = Values.FOX_INITIATIVE;
    }

    public override void Display() {
      var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
      button.Text = Values.FOX_TEXT;
      button.ForeColor = Color.FromArgb(255, 170, 0);
      button.BackColor = Color.FromArgb(119, 70, 34);
    }

    private bool FoxCantMove((int, int)position) {
      if (WorldRef.IsSpotVacant(position))
        return false;

      var otherOrganism = WorldRef.OrganismAtPosition(position);
      if (otherOrganism != null)
        return otherOrganism.Strength >= Strength;

      return false;
    }

    public override void TakeTurn() {
      var newPos = WorldRef.NextMove(Position);
      if (newPos.Equals(Position) || FoxCantMove(newPos))
        return;

      var foundOrganism = WorldRef.OrganismAtPosition(newPos);
      if (foundOrganism != null)
        Collision(foundOrganism);
      else
        Position = newPos;
    }
  }
}
