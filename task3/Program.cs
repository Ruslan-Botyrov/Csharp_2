// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
int numberA = Prompt("Введите число A");
int numberB = Prompt("Введите число B");

int numberC = numberB % numberA;

if (numberB % numberA == 0) Console.WriteLine("второе число кратно первому");
else Console.WriteLine($"остаток от деления второго на первое = {numberC}");

int Prompt(String prombt)
{
    Console.WriteLine(prombt);
    string inputNumberA = Console.ReadLine();
    int numberA = int.Parse(inputNumberA);
    return numberA;
}
