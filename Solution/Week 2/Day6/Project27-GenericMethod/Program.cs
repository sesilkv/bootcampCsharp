public class ToyBox
{
    private object toy;

    public void AddToy<T>(T newToy)
    {
        toy = newToy;
    }

    public T GetToy<T>()
    {
        return (T)toy;
    }
}
class Program
{
    static void Main()
    {
        ToyBox toyBox = new ToyBox();
        toyBox.AddToy<string>("Teddy Bear");
        //toyBox.AddToy<int>(42);
        //toyBox.AddToy<double>(3.14);

        string teddyBear = toyBox.GetToy<string>();
        //int number = toyBox.GetToy<int>();
        //double pi = toyBox.GetToy<double>();

        Console.WriteLine(teddyBear); 
        //Console.WriteLine(number);    
        //Console.WriteLine(pi);        
    }
}