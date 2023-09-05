using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
namespace JsonSerialization;

class Program
{
	static void Main(string[] args)
	{
		var t1 = new Tile(1, "Start", TileType.CORNER_TILE);
		var t2 = new Tile(2, "Indonesia", TileType.PROPERTY);
		var t3 = new Tile(3, "China", TileType.PROPERTY);
		var t4 = new Tile(4, "Tax", TileType.TAX);
		var t5 = new Tile(5, "Water Works", TileType.UTILITY);

		List<Tile> tiles = new List<Tile>();
		tiles.Add(t1);
		tiles.Add(t2);
		tiles.Add(t3);
		tiles.Add(t4);

		// serialize
		DataContractJsonSerializer dcs = new DataContractJsonSerializer(typeof(List<Tile>));
		// // without formatter
		// using (FileStream fs1 = new FileStream("tile.json", FileMode.OpenOrCreate))
		// {
		// 	dcs.WriteObject(fs1, tiles);
		// }
		
		// with formatter
		FileStream fs1 = new FileStream("tile.json", FileMode.OpenOrCreate);
		using (var writer = JsonReaderWriterFactory.CreateJsonWriter(fs1, Encoding.UTF8, true, true, ""))
		{
			dcs.WriteObject(writer, tiles);
		}
		

		// deserialize
		List<Tile> getTile;
		using (FileStream fs2 = new FileStream("tile.json", FileMode.Open))
		{
			getTile = (List<Tile>)dcs.ReadObject(fs2);
		}

		foreach (var tile in getTile)
		{
			Console.WriteLine(tile.GetTile());
		}
	}
}

public enum TileType
{
	CORNER_TILE,
	PROPERTY,
	TAX,
	UTILITY
}

[DataContract]
public class Tile
{
	[DataMember]
	private int _position;
	[DataMember]
	private string? _tileName;
	[DataMember]
	private TileType _tileType;

	public int Position { get => _position; set => _position = value; }
	public string? TileName { get => _tileName; set => _tileName = value; }
	public TileType TileType { get => _tileType; set => _tileType = value; }

	public Tile(int position, string? tileName, TileType tileType)
	{
		_position = position;
		_tileName = tileName;
		_tileType = tileType;
	}
	
	public string GetTile()
	{
		return "Position " + Position + " is " + TileName + " with " + TileType + " type"; 
	}
}
