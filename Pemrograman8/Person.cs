using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman8
{
	// Class Person yaitu sebagai Class Induk
	public class Person
	{
		// Property Class Person
		public string Name;
		public int Age;

		// Constructor Class Person
		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		// Method atau Fungsi yang menampilkan nama dan umur
		public void InfoPerson()
		{
			Console.WriteLine("Nama saya {0}, Umur saya {1} tahun", Name, Age);
		}


	}

	// Class Karyawan yaitu sebagai Class Turunan dari Class Person
	public class Karyawan : Person
	{
		// Property Class Karyawan
		public string KaryawanID;
		public string Subject;

		//Constructor Class Karyawan
		public Karyawan(string karyawanID, string subject, string name, int age) : base(name, age)
		{
			KaryawanID = karyawanID;
		    Subject = subject;
		}

		// Method Class Karyawan
		public void InfoKaryawan()
		{
			Console.Write("Saya berposisi sebagai {0} dengan ID {1}", Subject, KaryawanID);
		}

		//Override Method dari Class Person
		public void InfoPerson(string name, int age)
		{
			Console.WriteLine("Nama saya {0}, umur saya {1} tahun", Name, Age);
		}
	}
}
