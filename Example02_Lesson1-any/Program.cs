// -------------------- Вывод последней цифры терхзначного числа ---------------- //
Console.Clear();

Console.Write("Введите целое трехзначное число (от 100 до 999): ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 999 || number < 100)
{
    Console.WriteLine();
    Console.WriteLine("Надо было ввести число (от 100 до 999)");
    Console.Write("Повторите ввод числа (от 100 до 999): ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}
Console.WriteLine();
int thirdNumber = number % 10;
Console.WriteLine("Последняя цифра числа " + number + " - это " + thirdNumber);
Console.WriteLine("------------------------------------------------------");

// -------------------- Вывод последовательности от -N до N {-2, -1, 0, 1, 2} ---------------- //
Console.WriteLine("Следующий пример: вывод последовательности чисел");
Console.WriteLine();
Console.Write("Введите целое число (от 1 до 20): ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while (i <= num)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();
Console.WriteLine("------------------------------------------------------");