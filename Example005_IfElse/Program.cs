Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Привет Машулька");
}
else
{
    Console.WriteLine ("Привет,");
    Console.WriteLine (username);
}