// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int Prompt(String prombt)
{
    Console.WriteLine(prombt);
    string inputNumberA = Console.ReadLine();
    int numberA = int.Parse(inputNumberA);
    return numberA;
}

int number = Prompt("Введите число");

if ((number % 7 == 0) && (number % 23 == 0)) Console.WriteLine($"Число {number} кратное 7 и 23");
else Console.WriteLine($"Число {number} некратное 7 и 23");
