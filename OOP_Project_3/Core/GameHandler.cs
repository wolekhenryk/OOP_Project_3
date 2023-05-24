using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project_3.Core.Entities.Animals;

namespace OOP_Project_3.Core {
  internal class GameHandler {
    private readonly World world;
    private readonly Action mainAction;
    public GameHandler(World world, Action action) {
      this.world = world;
      mainAction = action;
    }

    public void Run() {
      world.GameForm.Size =
          new Size(Values.CELL_SIZE * (world.GetWidth() + 1) + 7 + world.GetWidth(),
                   Values.CELL_SIZE * (world.GetHeight() + 1) + 8 + world.GetHeight());

      world.GameForm.MouseClick += (_, _) => world.MakeTurn();

      world.AddOrganism(OrganismFactory.Create(typeof(Wolf), (0, 1), world));
      world.AddOrganism(OrganismFactory.Create(typeof(Wolf), (1, 0), world));
      world.AddOrganism(OrganismFactory.Create(typeof(Wolf), (2, 1), world));
      world.AddOrganism(OrganismFactory.Create(typeof(Fox), (1, 1), world));

      world.Display();
      world.ShowGameWindow();
    }

    private void HandleEnterKeyDown(object sender, MouseEventArgs e) => mainAction?.Invoke();
  }
}
