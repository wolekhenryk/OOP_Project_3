using System;
using OOP_Project_3.Core.Entities;
using OOP_Project_3.Core.Entities.Animals;
using OOP_Project_3.Core.Entities.Plants;

namespace OOP_Project_3.Core;

public static class OrganismFactory {
  public static Organism Create(string className, (int, int)position, World world) {
    return className switch { nameof(Wolf) => new Wolf(position, world),
                              nameof(Sheep) => new Sheep(position, world),
                              nameof(Fox) => new Fox(position, world),
                              nameof(Tortoise) => new Tortoise(position, world),
                              nameof(Gazelle) => new Gazelle(position, world),
                              nameof(CyberSheep) => new CyberSheep(position, world),
                              nameof(Grass) => new Grass(position, world),
                              nameof(Sosnowski) => new Sosnowski(position, world),
                              nameof(Mlecz) => new Mlecz(position, world),
                              nameof(Guarana) => new Guarana(position, world),
                              nameof(WilczaJagoda) => new WilczaJagoda(position, world),
                              _ => throw new ArgumentException() };
  }

  public static Organism Create(Type classType,
                                (int, int)position,
                                World world) => Create(classType.Name, position, world);
}
