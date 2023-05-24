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

    public const int FOX_STRENGTH = 3;
    public const int FOX_INITIATIVE = 7;
    public const string FOX_TEXT = "\uD83E\uDD8A";

    public const int TORTOISE_STRENGTH = 2;
    public const int TORTOISE_INITIATIVE = 1;
    public const int TORTOISE_MOVE_CHANCE = 2;
    public const string TORTOISE_TEXT = "\ud83d\udc22";

    public const int GAZELLE_STRENGTH = 4;
    public const int GAZELLE_INITIATIVE = 4;
    public const string GAZELLE_TEXT = "\uD83E\uDD8C";
  }
}
