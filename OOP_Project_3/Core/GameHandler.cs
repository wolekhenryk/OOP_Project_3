using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_3.Core
{
    internal class GameHandler
    {
        private readonly World world;

        public GameHandler(World world) => this.world = world;

        public void Run()
        {
            world.GameForm.Size = new Size(Values.CELL_SIZE * (world.GetWidth() + 1) + 7 + world.GetWidth(),
                Values.CELL_SIZE * (world.GetHeight() + 1) + 8 + world.GetHeight());

            world.ShowGameWindow();
        }
    }
}
