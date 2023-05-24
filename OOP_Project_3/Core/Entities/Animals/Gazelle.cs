using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_3.Core.Entities.Animals {
  internal class Gazelle : Animal {
    public Gazelle((int, int)position, World world) : base(position, world) {}
  }
}
