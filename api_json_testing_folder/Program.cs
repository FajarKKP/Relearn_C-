using System;
using System.Collections.Generic;
using System.Reflection;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;
using System.Net;

// var json = "{\"name\":\"John\",\"age\":\"30\"}";

// // Console.WriteLine(json);

// Person? person = JsonSerializer.Deserialize<Person>(json);

// Console.WriteLine(person?.age);

// public class Person
// {
//     public string? name {get; set;}
//     public string? age {get; set;}
// }

// public class Company
// {
//     public string? company_name {get; set;}
//     public string? role {get; set;}
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Company company = new Company
//         {
//             company_name = "Ken's WH",
//             role = "SoftEng"
//         };

//         string json_string = JsonSerializer.Serialize(company);

//         Console.WriteLine(json_string);
//     }
// }

public class Received_data
{
    public int? userId {get; set;}
    public int? id {get; set;}
    public string? title {get; set;}
    public string? body {get; set;}
}

// public class Program
// {

//     private static readonly HttpClient client = new HttpClient();

//     static async Task Main(string[] args)
//     {
//         string url = "https://jsonplaceholder.typicode.com/posts";

//         string json_response = await client.GetStringAsync(url);

//         // Console.WriteLine(json_response);

//         List<Received_data>? data = JsonSerializer.Deserialize<List<Received_data>>(json_response);

//         foreach (var data_arrived in data)
//         {
//             Console.WriteLine(data_arrived.id);
//             Console.WriteLine(data_arrived.title);
//             Console.WriteLine(data_arrived.userId);
//         }
//     }
// }

public class Program
{
    private static readonly HttpClient new_h_client = new HttpClient();

    static async Task Main(string[] args)
    {
        string url = "https://jsonplaceholder.typicode.com/posts";

        var newPost = new Received_data
        {
            userId = 27,
            id = 276,
            title = "Fkkp test Post",
            body = "Something something to post to something"
        };


        string json_post = JsonSerializer.Serialize(newPost);

        var content = new StringContent(json_post, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await new_h_client.PostAsync(url, content);

        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        Console.WriteLine("Response Status: " + response.StatusCode);
        Console.WriteLine("Response Body: " + responseBody);
    }
}