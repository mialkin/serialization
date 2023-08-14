using System;
using Serialization.Common;
using Serialization.Newtonsoft.Serializers;
using Serialization.SystemTextJson.Serializers;

var car = CarFactory.Build();

var defaultJsonSerializer = new DefaultJsonSerializer();
var camelCaseJsonSerializer = new CamelCaseJsonSerializer();
var redisJsonSerializer = new RedisJsonSerializer();
var newtonsoftJsonSerializer = new NewtonsoftJsonSerializer();

Console.WriteLine(defaultJsonSerializer.Serialize(car));
Console.WriteLine(camelCaseJsonSerializer.Serialize(car));
Console.WriteLine(redisJsonSerializer.Serialize(car));
Console.WriteLine(newtonsoftJsonSerializer.Serialize(car));

/*
Output:

{"Make":"Honda","Model":0,"YearOfProduction":2020,"Colors":{"Roof":"White","Wheels":"Dark grey"}}
{"make":"Honda","model":0,"yearOfProduction":2020,"colors":{"Roof":"White","Wheels":"Dark grey"}}
{"make":"Honda","model":"HondaCivic","yearOfProduction":2020,"colors":{"roof":"White","wheels":"Dark grey"}}
{"Make":"Honda","Model":0,"YearOfProduction":2020,"Colors":{"Roof":"White","Wheels":"Dark grey"}}

*/