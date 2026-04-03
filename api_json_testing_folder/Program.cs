using System;
using System.Collections.Generic;
using System.Text.Json;

var json = "{\"name\":\"John\",\"age\":\"30\"}";

// Console.WriteLine(json);

Person? person = JsonSerializer.Deserialize<Person>(json);

Console.WriteLine(person?.age);

public class Person
{
    public string? name {get; set;}
    public string? age {get; set;}
}