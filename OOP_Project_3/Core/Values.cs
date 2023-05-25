namespace OOP_Project_3.Core;

public static class Values {
  public const int CELL_SIZE = 60;

  public const int POSITION_ATTEMPTS = 5;

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

  public const int CYBERSHEEP_STRENGTH = 11;
  public const int CYBERSHEEP_INITIATIVE = 4;
  public const string CYBERSHEEP_TEXT = "\uD83D\uDC11";

  public const int FOX_STRENGTH = 3;
  public const int FOX_INITIATIVE = 7;
  public const string FOX_TEXT = "\uD83E\uDD8A";

  public const int TORTOISE_STRENGTH = 2;
  public const int TORTOISE_INITIATIVE = 1;
  public const int TORTOISE_MOVE_CHANCE = 2;
  public const string TORTOISE_TEXT = "\ud83d\udc22";

  public const int GAZELLE_STRENGTH = 4;
  public const int GAZELLE_INITIATIVE = 4;
  public const int GAZELLE_FACTOR = 2;
  public const string GAZELLE_TEXT = "\uD83E\uDD8C";

  public const int PLANT_INITIATIVE = 0;
  public const int WEAK_STRENGTH = 0;

  public const int GRASS_SPREAD_CHANCE = 5;
  public const string GRASS_TEXT = "\uD83C\uDF3A";

  public const int BARSZCZ_SPREAD_CHANCE = 2;
  public const int BARSZCZ_STRENGTH = 10;
  public const string BARSZCZ_TEXT = "\uD83C\uDF35";

  public const int MLECZ_SPREAD_CHANCE = 3;
  public const int MLECZ_ATTEMPTS = 3;
  public const string MLECZ_TEXT = "\uD83C\uDF3B";

  public const int GUARANA_SPREAD_CHANCE = 3;
  public const int GUARANA_POWER = 3;
  public const string GUARANA_TEXT = "\uD83C\uDF31";

  public const int NIGHTSHADE_SPREAD_CHANCE = 2;
  public const string NIGHTSHADE_TEXT = "\uD83C\uDF53";
}
