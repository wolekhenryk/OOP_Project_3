using System;
using System.Collections.Generic;
using System.Linq;
using MaterialSkin.Controls;
using OOP_Project_3.Core.Entities;
using OOP_Project_3.Visual;

namespace OOP_Project_3.Core;

public abstract class World {
  public VisualFormManager GameManager { get; set; }
  public Game GameForm { get; set; }
  public IEnumerable<Organism> Organisms => organisms;

  protected List<Organism> organisms;
  protected LinkedList<string> logs;
  protected Random randomGenerator;
  protected ValueTuple<int, int> worldSize;
  protected Comparator organismComparator;

  protected World((int, int)size, MaterialForm gameForm) {
    GameManager = new VisualFormManager(gameForm);
    GameForm = (Game)gameForm;
    organisms = new List<Organism>();
    logs = new LinkedList<string>();
    randomGenerator = new Random();
    organismComparator = new Comparator();
    worldSize = size;

    GameManager.SetSize(size);
  }

  public abstract void Display();
  public abstract ValueTuple<int, int> FindFreeSpot((int, int)currentPosition);
  public abstract ValueTuple<int, int> NextMove((int, int)currentPosition, int factor = 1);
  public abstract void PlaceOrganism(Type classType);

  protected ValueTuple<int, int> GetRandomFreeSpot() {
    for (var i = 0; i < Values.POSITION_ATTEMPTS; i++) {
      var randomPos = (randomGenerator.Next(GetHeight()), randomGenerator.Next(GetWidth()));
      if (IsSpotVacant(randomPos))
        return randomPos;
    }
    return default;
  }
  public int GetHeight() => worldSize.Item1;
  public int GetWidth() => worldSize.Item2;
  public void ShowGameWindow() => GameForm.Show();
  public void AddOrganism(Organism organism) => organisms.Add(organism);
  protected bool InHeightBounds(int value) => value >= 0 && value < GetHeight();
  protected bool InWidthBounds(int value) => value >= 0 && value < GetWidth();

  public bool ValidCoords((int, int)valueTuple) => InHeightBounds(valueTuple.Item1) &&
                                                   InWidthBounds(valueTuple.Item2);
  public bool InvalidCoords((int, int)valueTuple) => !ValidCoords(valueTuple);

  public bool IsSpotVacant((int,
                            int)valueTuple) => !Organisms.Any(o => o.Position.Equals(valueTuple));

  public Organism OrganismAtPosition((int, int)valueTuple) =>
      Organisms.FirstOrDefault(o => o.Position.Equals(valueTuple));

  public void Message(string message) {
    logs.AddLast(message);

    if (logs.Count > 20)
      logs.RemoveFirst();

    GameForm.GetLogTextBox().ResetText();

    foreach (var msg in logs)
      GameForm.GetLogTextBox().AppendText(msg + "\n");
  }

  public int GetRandomNumber(int start, int end) => randomGenerator.Next(start, end);

  public void MakeTurn() {
    organisms.Sort(organismComparator);
    Display();
    var copyOrganisms = new List<Organism>(organisms);
    copyOrganisms.ForEach(o => o.TakeTurn());
    organisms.RemoveAll(o => o.IsDead);
  }
}

public class Comparator : IComparer<Organism> {
  public int Compare(Organism x, Organism y) {
    if (x == null || y == null)
      throw new NullReferenceException();
    var firstComp = x.Strength.CompareTo(y.Strength);
    return firstComp != 0 ? firstComp : x.Age.CompareTo(y.Age);
  }
}
