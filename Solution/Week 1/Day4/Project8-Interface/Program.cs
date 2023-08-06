using PrinterLibrary;

public class Program
{
	static void Main() {
		Printer3Juta print3 = new();
		// Printer700Ribu print2 = new();
		Printer300Ribu print1 = new();
		
		IPrint printerMurah = print1;
		printerMurah.Print();
		
		IPrinterMahal printerMahal = print3;
		printerMahal.Print();
		printerMahal.Scan();
		printerMahal.Fax();
		
		IScan printerscan = print3;
		printerscan.Scan();
		}

}