int numberA = new Random().Next(0, 15); // 0,1,2,...14
Console.WriteLine("1-е случайное число = " + numberA);
int numberB = new Random().Next(0, 15);
Console.WriteLine("2-е случайное число = " + numberB);
int result = numberA + numberB;
Console.WriteLine("Сумма чисел = " + result);