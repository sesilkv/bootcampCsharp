namespace DelegateExample;
	public delegate void SimpleDelegate(); 
	class Program
	{
		static void Main(string[] args)
		{
			SimpleDelegate myDelegate = SayHello;
            myDelegate();
			myDelegate += SayHi;
			myDelegate();
		}
		static void SayHello()
		{
			Console.WriteLine("Halo!");
		}
		static void SayHi() 
		{
			Console.WriteLine("Hi!");
		}
	}
