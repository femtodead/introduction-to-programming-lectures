Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Привет САНЕК, ты лучший!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}