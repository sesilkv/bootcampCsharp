namespace HitungGaji;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Nama Karyawan:");
		string? name = Console.ReadLine();
		Console.WriteLine("Jam Lembur (0-10):");
		int jamLembur = int.Parse(Console.ReadLine());
		
		//hitung bonus
		int bonus = 800000 * jamLembur;
		int totalGaji = 1500000 + bonus;
		
		Console.WriteLine("\nRekap Input Data");
		Console.WriteLine($"Nama Pegawai: {name}");
		Console.WriteLine($"Jam Lembur: {jamLembur}");
		Console.WriteLine($"Total Gaji: {totalGaji}");	
		Console.WriteLine("\nPress any key to continue...");
		Console.ReadKey();
	}