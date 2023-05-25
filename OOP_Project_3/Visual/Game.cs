using System.Windows.Forms;
using MaterialSkin.Controls;

namespace OOP_Project_3.Visual {
  public partial class Game : MaterialForm {
    public Game() => InitializeComponent();
    public TableLayoutPanel GetGrid() => gridPanel;
    public MaterialMultiLineTextBox GetLogTextBox() => logTextBox;
  }
}
