namespace GetSet;

public interface IEngine {
	public int x {get; set;}
	void Run();
	void Start();
}

class Car {
	//Variable
	public int x;
	public string y;
	public IEngine engine;
	private string _name;

	//Property or Variable Method 
	public int z { get; private set; }
	public string name { 
		get {
			return _name;
		}
		set {
			_name += value;	// _name = _name + value;
		}
	}
	public string q { 
	get
	{
		return q + "World";
	}
	set
	{ 
		q = value + "Hello";
	} 
	}

	//Method
	public void Run() { }
	public int Stop() { return 0; }
	public int Stop(int x) { return x; }
}