using System.Collections.Generic;

namespace Serialization.Zoo.Models;

internal class Car
{
    public string Make { get; set; }
    public CarModel Model { get; set; }
    public int YearOfProduction { get; set; }
    public Dictionary<string, string> Colors { get; set; }
}