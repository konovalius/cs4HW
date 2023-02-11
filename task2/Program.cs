//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"--------------->{Result(number)}");

int Result (int numb)
{
   int Result = 0;
   for (; numb > 0; numb /= 10)
  {
   Result = Result + numb%10;
  }
  return Result;
}
