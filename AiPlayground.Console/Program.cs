using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

var my_api_key = ""; // leave empty for now

var http = new HttpClient();

http.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", my_api_key);

var requestBody = new ChatRequest
{
    model = "gpt-4.1-mini",
    temperature = 0,
    messages = new List<Message>
    {
        new Message
        {
            role = "system",
            content = "You are a useful, skeptical assistant."
        },
        new Message
        {
            role = "user",
            content = "Summarize: Chatgpt helps developers build faster."
        }
    }
};

var json = JsonSerializer.Serialize(requestBody);
var content = new StringContent(json, Encoding.UTF8, "application/json");

var response = await http.PostAsync("https://api.openai.com/v1/chat/completions", content);
var result = await response.Content.ReadAsStringAsync();

Console.WriteLine(result);

public class ChatRequest
{
    public string model { get; set; }
    public List<Message> messages { get; set; }
    public double temperature { get; set; }
}

public class Message
{
    public string role { get; set; }
    public string content { get; set; }
}