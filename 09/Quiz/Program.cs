using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz {
class Program {
static void Main(string[] args) {
Console.WriteLine("Какая команда завершает цикл в C#?");

Console.WriteLine("a. quit");
Console.WriteLine("b. continue");
Console.WriteLine("c. break");
Console.WriteLine("d. exit");

AskQuiz("c");
}

static void AskQuiz(string correctAnswer) {
string goOn = "yes";
while (goOn == "yes") {
Console.WriteLine();
Console.WriteLine("Введите ответ (или х для завершения программы)");
string answer = Console.ReadLine();

if (answer == correctAnswer) {
Console.WriteLine("Верно!!");
Thread.Sleep(1000);
break;
}
else if (answer == "x") {
Console.WriteLine("Завершение программы");
Thread.Sleep(1000);
goOn = "no";
}
else {
Console.WriteLine("Неверно!");
}
}
}
}
}
