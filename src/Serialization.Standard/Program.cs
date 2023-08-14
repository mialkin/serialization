using System;
using System.Collections.Generic;
using Serialization.Standard.Models;
using Serialization.Standard.Serializers;

var car = CreateCar();

var defaultJsonSerializer = new DefaultJsonSerializer();
var camelCaseJsonSerializer = new CamelCaseJsonSerializer();
var redisJsonSerializer = new RedisJsonSerializer();

var defaultJson = defaultJsonSerializer.Serialize(car);
var camelCaseJson = camelCaseJsonSerializer.Serialize(car);
var redisJson = redisJsonSerializer.Serialize(car);

Console.WriteLine(defaultJson);
Console.WriteLine(camelCaseJson);
Console.WriteLine(redisJson);

/*
Output:

{"Make":"Honda","Model":0,"YearOfProduction":2020,"Colors":{"Roof":"White","Wheels":"Dark grey"}}
{"make":"Honda","model":0,"yearOfProduction":2020,"colors":{"Roof":"White","Wheels":"Dark grey"}}
{"make":"Honda","model":"HondaCivic","yearOfProduction":2020,"colors":{"roof":"White","wheels":"Dark grey"}}

*/

Car CreateCar()
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