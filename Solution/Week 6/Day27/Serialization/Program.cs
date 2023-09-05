using System.Text.Json;
namespace JSONSerialization;

class Program
{
	static void Main(string[] args)
	{
		// Serialize
		List<Tile> tiles = new List<Tile> 
		{
			new Tile { Position = 1, TileName = "Start"},
			new Tile { Position = 2, TileName = "Indonesia"},
			new Tile { Position = 3, TileName = "China"},
			new Tile { Position = 4, TileName = "Tax"},
			new Tile { Position = 5, TileName = "Water Works"}
		};
		
		string json = JsonSerializer.Serialize(tiles);
		using (StreamWriter sw = new StreamWriter("tile.json"))
		{
			sw.Write(json);	
		}
		
		string jsonReader;
		using (StreamReader sr = new StreamReader("tile.json"))
		{
			jsonReader = sr.ReadToEnd();
		}
		
		// deserialize
		List<Tile> deserializedTile = JsonSerializer.Deserialize<List<Tile>>(jsonReader);
		foreach(var tile in deserializedTile)
		{
			Console.WriteLine($"Position {tile.Position} is {tile.TileName}");
		}
	}
}

public class Tile
{
	private int _position;
	private string? _tileName;
	
	public int Position { get => _position; set => _position = value; }
	public string? TileName { get => _tileName; set => _tileName = value; }
}