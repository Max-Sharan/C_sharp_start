// int a = new Random().Next(1, 10);
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int quad = a * a;
// int quadro = b * b; 
// Console.WriteLine("Квадрат числа " + a + " равен " + quad);
// Console.WriteLine("Квадрат числа " + b + " равен " + quadro);

// ----------------------- Проверяем квадрат числа -------------------------------------- //

// Console.Write("Введите целое число x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int xQuad = x * x;

// if (y == xQuad)
// {
//     Console.Write("y = " + y + " - это квадрат числа x = " + x);
// }
// else
// {
//     Console.Write("y = " + y + ", не является квадратом числа x = " + x);
// }
// ----------------------- Выводим дни недели -------------------------------------- //

Console.Write("Введите номер дня на неделе (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());

string mon = "понедельник";
string the = "вторник";
string wen = "среда";
string thu = "четверг";
string fri = "пятница";
string sat = "суббота";
string sun = "воскресенье";

if (day == 1)
{
    Console.Write("Сегодня - " + mon);
}
else if(day == 2)
{
    Console.Write("Сегодня - " + the);
}
else if(day == 3)
{
    Console.Write("Сегодня - " + wen);
}
else if(day == 4)
{
    Console.Write("Сегодня - " + thu);
}
else if(day == 5)
{
    Console.Write("Сегодня - " + fri);
}
else if(day == 6)
{
    Console.Write("Сегодня - " + sat);
}
else if(day == 7)
{
    Console.Write("Сегодня - " + sun);
}
else
{
    Console.Write("В неделе только 7 дней!");
}