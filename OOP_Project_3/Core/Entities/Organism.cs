using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_3.Core.Entities {
  public abstract class Organism {
    public int Strength { get; protected set; }
    public int Initiative { get; protected set; }
    public bool IsDead { get; protected set; }
    public ValueTuple<int, int> Position { get; protected set; }
    public World WorldRef { get; protected set; }
    public int Age { get; protected set; }
    protected Organism((int, int)position, World world) {
      Position = position;
      WorldRef = world;
    }
    public virtual void TakeTurn() => Age++;
    public abstract void Display();
    public abstract void Collision(Organism other);
    public void Die() => IsDead = true;
  }
}
