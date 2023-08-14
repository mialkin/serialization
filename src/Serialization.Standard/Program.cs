using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serialization.Standard.Models;
using Serialization.Standard.Serializers;
using Serialization.Standard.Serializers.Interfaces;

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

IDefaultJsonSerializer defaultJsonSerializer = new DefaultJsonSerializer();
ICamelCaseJsonSerializer camelCaseJsonSerializer = new CamelCaseJsonSerializer();

var defaultJson = defaultJsonSerializer.Serialize(car);
var camelCaseJson = camelCaseJsonSerializer.Serialize(car);

var defaultCar = defaultJsonSerializer.Deserialize<Car>(defaultJson);
var camelCaseCar = camelCaseJsonSerializer.Deserialize<Car>(camelCaseJson);

Console.WriteLine(defaultJson);
Console.WriteLine(camelCaseJson);

// Output:
/*

{"Make":"Honda","Model":0,"YearOfProduction":2020,"Colors":{"Roof":"White","Wheels":"Dark grey"}}
{"make":"Honda","model":0,"yearOfProduction":2020,"colors":{"Roof":"White","Wheels":"Dark grey"}}

*/