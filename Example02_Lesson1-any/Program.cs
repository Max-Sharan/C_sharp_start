// -------------------- Вывод последней цифры терхзначного числа ---------------- //

Console.Write("Введите целое трехзначное число (от 100 до 999): ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdNumber = number % 10;

Console.WriteLine("Последняя цифра числа " + number + " - это " + thirdNumber);

// -------------------- Вывод последовательности от -N до N {-2, -1, 0, 1, 2} ---------------- //

Console.Write("Введите целое число (от 1 до 20): ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while (i <= num)
{
    Console.Write(i + ", ");
    i++;
}