using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using OOP_Project_3.Core.Entities;
using OOP_Project_3.Visual;

namespace OOP_Project_3.Core {
  public abstract class World {
    public VisualFormManager GameManager { get; set; }
    public Game GameForm { get; set; }
    public IEnumerable<Organism> OrganismsReadOnly => organisms;

    protected List<Organism> organisms;
    protected LinkedList<string> logs;
    protected Random randomGenerator;
    protected ValueTuple<int, int> worldSize;

    protected World((int, int)size, MaterialForm gameForm) {
      GameManager = new VisualFormManager(gameForm);
      GameForm = (Game)gameForm;
      organisms = new List<Organism>();
      logs = new LinkedList<string>();
      randomGenerator = new Random();
      worldSize = size;

      GameManager.SetSize(size);

      GameManager.SetSize(size);
    }

    public abstract void Display();
    public abstract ValueTuple<int, int> FindFreeSpot((int, int)currentPosition);
    public abstract ValueTuple<int, int> NextMove((int, int)currentPosition);
    public int GetHeight() => worldSize.Item1;
    public int GetWidth() => worldSize.Item2;
    public void ShowGameWindow() => GameForm.Show();
    public void AddOrganism(Organism organism) => organisms.Add(organism);
    protected bool InHeightBounds(int value) => value >= 0 && value < GetHeight();
    protected bool InWidthBounds(int value) => value >= 0 && value < GetWidth();

    public bool ValidCoords((int, int)valueTuple) => InHeightBounds(valueTuple.Item1) &&
                                                     InWidthBounds(valueTuple.Item2);
    public bool InvalidCoords((int, int)valueTuple) => !ValidCoords(valueTuple);

    public bool IsSpotVacant((int, int)valueTuple) =>
        OrganismsReadOnly.Any(o => o.Position.Equals(valueTuple));

    public Organism OrganismAtPosition((int, int)valueTuple) =>
        OrganismsReadOnly.FirstOrDefault(o => o.Position.Equals(valueTuple));

    public void Message(string message) {}

    public void MakeTurn() {
      Display();
      var copyOrganisms = new List<Organism>(organisms);
      copyOrganisms.ForEach(o => o.TakeTurn());
      organisms.RemoveAll(o => o.IsDead);
    }
  }
}
