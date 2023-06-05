using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=======================");
			Console.WriteLine("||    Class Induk    ||");
			Console.WriteLine("=======================");
			// Object Class Person dengan menggunakan Constructor
			Person person1 = new Person("Adib Ramadhan", 29);
			// Memanggil Method Class Person
			person1.InfoPerson();

			Console.WriteLine("\n=======================");
			Console.WriteLine("||   Class Turunan   ||");
			Console.WriteLine("=======================");
			// Object Class Karyawan dengan menggunakan Constructor
			Karyawan karyawan1 = new Karyawan("23901117", "Direktur Keuangan", "Rizki Anandra", 32);
			// Memanggil Method Override dari Class Person ke Class Karyawan
			karyawan1.InfoPerson();
			// Memanggil Method Class Karyawan
			karyawan1.InfoKaryawan();
			Console.ReadKey();

		}
	}
}

