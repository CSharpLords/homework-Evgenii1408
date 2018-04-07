using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostNumerousPenguin {
	class Program {
		static void Main(string[] args) {
			string mostNumerous1 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
			string mostNumerous2 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
			Console.WriteLine(mostNumerous1);
			Console.WriteLine(mostNumerous2);

			Console.ReadLine();
		}

		static string GetMostNumerous(string[] penguins) {
			return "";
		}
	}
}
