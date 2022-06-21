Console.Write("Представьтесь программе: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРА! Это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + username + "!");
}