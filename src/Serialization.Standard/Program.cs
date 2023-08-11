using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serialization.Standard.Models;

var options = new JsonSerializerOptions
{
    Converters = { new JsonStringEnumConverter() },
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
    // WriteIndented = true
};

var car = new Car
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

var serializedWithOptions = JsonSerializer.Serialize(car, options);
var serializedWithoutOptions = JsonSerializer.Serialize(car);

Console.WriteLine(serializedWithOptions);
Console.WriteLine(serializedWithoutOptions);

// Output:
/*

{"make":"Honda","model":"HondaCivic","yearOfProduction":2020,"colors":{"roof":"White","wheels":"Dark grey"}}
{"Make":"Honda","Model":0,"YearOfProduction":2020,"Colors":{"Roof":"White","Wheels":"Dark grey"}}

*/