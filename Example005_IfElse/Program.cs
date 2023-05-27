Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "алена")
{
Console.WriteLine("Привет, самый любимый котенок!!!!!");
}
else
{
    Console.WriteLine("Добрый день,");
    Console.WriteLine(username);
}