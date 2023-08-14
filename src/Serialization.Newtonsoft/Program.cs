using System;
using Serialization.Common;
using Serialization.Newtonsoft.Serializers;

var car = CarFactory.Build();

var newtonsoftJsonSerializer = new NewtonsoftJsonSerializer();
var result = newtonsoftJsonSerializer.Serialize(car);

Console.WriteLine(result);

// {"Make":"Honda","Model":0,"YearOfProduction":2020,"Colors":{"Roof":"White","Wheels":"Dark grey"}}
