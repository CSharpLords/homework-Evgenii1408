using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteHell {
	class Program {
		static void Main(string[] args) {
			float[] numbers = { 765, 341, 1, -3, 0, 13, -200, 23, 44 };

			numbers[0] = numbers[0] / 5;
			numbers[1] = numbers[1] / 5;
			numbers[2] = numbers[2] / 5;
			numbers[3] = numbers[3] / 5;
			numbers[4] = numbers[4] / 5;
			numbers[5] = numbers[5] / 5;
			numbers[6] = numbers[6] / 5;
			numbers[7] = numbers[7] / 5;
			numbers[8] = numbers[8] / 5;
			Console.ReadLine();
		}
	}
}
