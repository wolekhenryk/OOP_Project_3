using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OOP_Project_3.Core.Entities.Plants;

namespace OOP_Project_3.Core.Entities.Animals;

internal class CyberSheep : Animal {
  public CyberSheep((int, int)position, World world) : base(position, world) {
    Strength = Values.CYBERSHEEP_STRENGTH;
    Initiative = Values.CYBERSHEEP_INITIATIVE;
  }

  private static double CalculateDistance((int, int)pos1, (int, int)pos2) {
    var (x1, y1) = pos1;
    var (x2, y2) = pos2;

    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
  }
  private Sosnowski FindClosestPlant() {
    var plants = WorldRef.Organisms.OfType<Sosnowski>().ToList();

    if (!plants.Any())
      return null;

    var distances = new SortedDictionary<double, Sosnowski>();

    plants.ForEach(plant => {
      var distance = CalculateDistance(plant.Position, Position);
      if (!distances.ContainsKey(distance)) {
        distances.Add(distance, plant);
      }
    });

    var closestPlant = distances.First().Value;
    return closestPlant;
  }

  private IEnumerable<(int, int)> GetValidMoves() {
    var (i, j) = Position;
    var possibleMoves = new List<(int, int)>();

    for (var index = 0; index < Values.SQUARE_MOVES; index++) {
      var newPos = (i + Values.SquareDy[index], j + Values.SquareDx[index]);
      if (WorldRef.ValidCoords(newPos))
        possibleMoves.Add(newPos);
    }

    return possibleMoves;
  }

  public override void TakeTurn() {
    var closestPlant = FindClosestPlant();
    if (closestPlant == null) {
      base.TakeTurn();
      return;
    }

    if (closestPlant.Position.Equals(Position)) {
      Eat(closestPlant);
      return;
    }

    double Compare((int, int)move) => CalculateDistance(move, closestPlant.Position);

    var possibleMoves = GetValidMoves();
    var bestMove = possibleMoves.OrderBy(Compare).First();

    var otherOrganism = WorldRef.OrganismAtPosition(bestMove);
    if (otherOrganism == null)
      Position = bestMove;
    else
      Collision(otherOrganism);
  }

  public override void Display() {
    var button = ((WorldSquareImpl)WorldRef).ControlAtPosition(Position);
    button.Text = Values.SHEEP_TEXT;
    button.ForeColor = Color.LightGray;
    button.BackColor = Color.DarkGray;
  }
}
