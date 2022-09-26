// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите основание степени A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени B: ");
int b;
while (true)
{
   b = Convert.ToInt32(Console.ReadLine());
   if (b > 0)
   {
      break;
   }
   Console.WriteLine("Введите положительное число B: ");
}


int z = Convert.ToInt32(Math.Pow(a, b));
Console.Write(a + " в степени " + b + " = " + z);
