using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_3.Core {
  public static class Values {
    public const int CELL_SIZE = 60;

    public const int BTN_FONT_SIZE = 32;

    public const int SQUARE_MOVES = 4;
    public const int SQUARE_ATTEMPTS = 10;

    public static readonly int[] SquareDx = { 0, 1, 0, -1 };
    public static readonly int[] SquareDy = { 1, 0, -1, 0 };

    public const int WOLF_STRENGTH = 9;
    public const int WOLF_INITIATIVE = 4;
    public const string WOLF_TEXT = "\ud83d\udc3a";

    public const int SHEEP_STRENGTH = 4;
    public const int SHEEP_INITIATIVE = 4;
    public const string SHEEP_TEXT = "\uD83D\uDC11";
  }
}
