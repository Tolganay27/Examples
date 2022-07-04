Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "толганай")
{
    Console.WriteLine("Ура, это же Токи!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}