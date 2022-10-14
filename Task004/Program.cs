// Учимсыя использовать ветвление
Console.Write("Введите свое имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "оля")
{
Console.WriteLine("Оля-ля, да это же ОЛЯ!");
}
else
{
Console.Write("Здравствуй, ");
Console.Write(username);
}