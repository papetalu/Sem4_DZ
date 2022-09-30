// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
Console.Clear();

int[] myArray = new int[8];

{
   for (int i = 0; i < 8; i++)
{
   Console.Write($"Введите элемент массива № {i}: ");
   myArray[i] = int.Parse(Console.ReadLine());

}
}

Console.WriteLine("Вывод массива: ");
Console.WriteLine("[" + string.Join(", ", myArray) + "]");
