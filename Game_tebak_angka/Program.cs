using System;
using System.Linq;

namespace Game_tebak_angka;

public static class Program
{
	public static void Main()
	{
		    Random random = new Random();
		    Double angkaacak = random.Next(1,100);
		
				
			Console.WriteLine("----------------");
			Console.WriteLine("game tebak angka");
			Console.WriteLine("----------------");
			
			while(true)
			{
				Console.WriteLine("masukan tebakan anda");
				Double pilihanusr = Convert.ToDouble(Console.ReadLine());
				if (pilihanusr == angkaacak)	
				{
					    Console.WriteLine("selamat kamu menang");
						Console.WriteLine("kelik enter untuk lanjut");
						Console.ReadKey();
						Console.Clear();
				}
				else if(pilihanusr <angkaacak)	
				{
					    Console.WriteLine("angka terlalu rendah");
						
				}
				else if(pilihanusr > angkaacak)		
				{
				Console.WriteLine("angka terlalu tinggi");
				
				}
			}	

	}
}
