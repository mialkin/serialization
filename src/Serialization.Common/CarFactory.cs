using System.Collections.Generic;
using Serialization.Common.Models;

namespace Serialization.Common;

public abstract class CarFactory
{
    public static Car Build()
    {
        return new Car
        {
            Make = "Honda",
            Model = CarModel.HondaCivic,
            YearOfProduction = 2020,
            Colors = new Dictionary<string, string>
            {
                { "Roof", "White" },
                { "Wheels", "Dark grey" }
            }
        };
    }
}