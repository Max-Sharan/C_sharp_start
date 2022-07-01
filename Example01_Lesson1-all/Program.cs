// int a = new Random().Next(1, 10);
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int quad = a * a;
// int quadro = b * b; 
// Console.WriteLine("Квадрат числа " + a + " равен " + quad);
// Console.WriteLine("Квадрат числа " + b + " равен " + quadro);

// ----------------------- Проверяем квадрат числа -------------------------------------- //

Console.Write("Введите целое число x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число y: ");
int y = Convert.ToInt32(Console.ReadLine());
int xQuad = x * x;

if (y == xQuad)
{
    Console.Write("y = " + y + " - это квадрат числа x = " + x);
}
else 
{
    Console.Write("y = " + y + ", не является квадратом числа x = " + x);
}
// ----------------------- Выводим дни недели -------------------------------------- //

