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
  public partial class Game : MaterialForm {
    public Game() => InitializeComponent();
    public TableLayoutPanel GetGrid() => gridPanel;
  }
}
