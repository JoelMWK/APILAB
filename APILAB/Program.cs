using RestSharp;
using System.Text.Json;
using System.Net;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest request = new RestRequest("pokemon/wobbuffet");
RestResponse response = pokeClient.GetAsync(request).Result;

string item;
string number;

Console.WriteLine("Choose a category (people/starships/planets/films)");
item = Console.ReadLine().ToLower();

Console.WriteLine("Choose a number for your chosen category");
number = Console.ReadLine();

Console.Clear();

RestClient StarWarsClient = new RestClient("https://swapi.py4e.com/api");
RestRequest request1 = new RestRequest($"{item}/{number}");
RestResponse response1 = StarWarsClient.GetAsync(request1).Result;



/*if (response.StatusCode == HttpStatusCode.OK)
{
    Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);

    Console.WriteLine(p.Name);
    Console.WriteLine(p.Id);

    Console.WriteLine(p.Weight);
    Console.WriteLine(p.Height);
}*/
if (response1.StatusCode == HttpStatusCode.OK)
{
    StarWars s = JsonSerializer.Deserialize<StarWars>(response1.Content);

    //SUPER GOOD CODE//
    if (item == "people")
    {
        Console.WriteLine($"Name: {s.Name}");
        Console.WriteLine($"Height: {s.Height}");
        Console.WriteLine($"Mass: {s.Mass}");
    }
    else if (item == "starships")
    {
        Console.WriteLine($"Name: {s.Name}");
        Console.WriteLine($"Length: {s.Length}");
    }
    else if (item == "planets")
    {
        Console.WriteLine($"Name: {s.Name}");
        Console.WriteLine($"Population: {s.Population}");
    }
    else if (item == "films")
    {
        Console.WriteLine($"Tile: {s.Title}");
        Console.WriteLine($"Release date: {s.ReleaseDate}");
    }
}
else
{
    Console.WriteLine("Something went wrong!");
}

Console.ReadLine();