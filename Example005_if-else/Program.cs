Console.Write("Введите пожалуйста своё имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша! Наконец-то ты пришла!");
}
else
{
    Console.WriteLine("Привет, " + username + "!");
}