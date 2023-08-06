namespace PrinterLibrary;

//interface tidak bisa diberikan variabel, hanya method
public interface IPrint {
	//declare menggunakan method
	void Print();
}
public interface IFax {
	void Fax();
}
public interface IScan {
	void Scan();
}
//multiple inherit
public interface IPrinterMahal: IPrint, IScan, IFax 
{
}

public class Printer300Ribu : IPrint {
	public void Print() {
		Console.WriteLine("Printing Murah");
	}
}

//1 class bisa punya multiple interface
public class Printer700Ribu : IPrint, IScan {
	public void Print() {
		Console.WriteLine("Printing");
	}
	public void Scan() {
		Console.WriteLine("Scanning");
	}
}
public class Printer3Juta : IPrinterMahal
{
	public void Print() {
		Console.WriteLine("Printing High Quality");
	}
	public void Scan() {
		Console.WriteLine("Scanning");
	}
	public void Fax() {
		Console.WriteLine("Faxing");
	}
}