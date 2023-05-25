using System;
using System.Drawing;
using OOP_Project_3.Core.Entities.Animals;
using OOP_Project_3.Core.Entities.Plants;

namespace OOP_Project_3.Core;

internal class GameHandler {
  private readonly World world;
  private readonly Action mainAction;
  public GameHandler(World world, Action action) {
    this.world = world;
    mainAction = action;
  }

  public void Run() {
    world.GameForm.Size =
        new Size(Values.CELL_SIZE * (world.GetWidth() + 2) + 7 + world.GetWidth(),
                 Values.CELL_SIZE * (world.GetHeight() + 2) + 9 + world.GetHeight());

    world.PlaceOrganism(typeof(Sheep));
    world.PlaceOrganism(typeof(Gazelle));
    world.PlaceOrganism(typeof(Fox));
    world.PlaceOrganism(typeof(Wolf));
    world.PlaceOrganism(typeof(Tortoise));

    world.PlaceOrganism(typeof(Grass));
    world.PlaceOrganism(typeof(Mlecz));
    world.PlaceOrganism(typeof(Guarana));
    world.PlaceOrganism(typeof(Guarana));
    world.PlaceOrganism(typeof(WilczaJagoda));
    world.PlaceOrganism(typeof(WilczaJagoda));

    world.PlaceOrganism(typeof(CyberSheep));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));
    world.PlaceOrganism(typeof(Sosnowski));

    world.Display();
    world.ShowGameWindow();
  }
}
