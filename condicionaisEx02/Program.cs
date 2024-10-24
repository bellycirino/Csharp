Console.WriteLine(@"
+....................................+
|         Bem- Vindo ao programa     |
|             Futebol                |
+....................................+
");

Console.WriteLine($"Digite os ponto de gols do time A");
int timeA = int.Parse (Console.ReadLine ()!);

Console.WriteLine($"Digite os ponto de gols do time B");
int timeB = int.Parse (Console.ReadLine ()!);

if (timeA > timeB)
{
    Console.WriteLine($"Vitoria Time A!");

} 
else if ( timeB > timeA)
{
    Console.WriteLine($"Vitoria Time B!");

} 
else
{
    Console.WriteLine($"O resultado foi um empate!");
}