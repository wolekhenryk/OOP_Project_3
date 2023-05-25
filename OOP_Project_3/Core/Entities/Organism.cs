using System;

namespace OOP_Project_3.Core.Entities;

public abstract class Organism {
  public int Strength { get; protected set; }
  public int Initiative { get; protected set; }
  public bool IsDead { get; protected set; }
  public ValueTuple<int, int> Position { get; protected internal set; }
  public World WorldRef { get; protected set; }
  public int Age { get; protected set; }
  protected Organism((int, int)position, World world) {
    Position = position;
    WorldRef = world;
  }
  public virtual void TakeTurn() => Age++;
  public abstract void Display();
  public void Die() => IsDead = true;
}
