using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace OOP_Project_3.Visual {
  public partial class Start : MaterialForm {
    public Start() => InitializeComponent();

    private void ButtonStartGame_Click(object sender, EventArgs e) {
      var (height, width) = (int.Parse(TextBoxHeight.Text), int.Parse(TextBoxWidth.Text));

      var world = new Core.WorldSquareImpl((height, width), new Game());

      var gameHandler = new Core.GameHandler(world, world.MakeTurn);

      gameHandler.Run();
      Hide();
    }
  }
}
