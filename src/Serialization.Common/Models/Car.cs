using System.Collections.Generic;

namespace Serialization.Common.Models;

public class Car
{
    public string Make { get; set; }
    public CarModel Model { get; set; }
    public int YearOfProduction { get; set; }
    public Dictionary<string, string> Colors { get; set; }
}