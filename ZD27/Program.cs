// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(n);
int[] Array = new int[a.Length];
int s = 0;
for (int i = 0; i < a.Length; i++) 
{
   Array[i] = int.Parse(a[i].ToString());
   s = s + Array[i];
}

Console.WriteLine(s);
