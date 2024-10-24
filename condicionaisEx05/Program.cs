Console.WriteLine(@"
+....................................+
|         Bem- Vindo ao programa     |
|             macas                  |
+....................................+
"); 

Console.WriteLine($"Digite a quatidade de macas compradas:");
float macas = float.Parse (Console.ReadLine());

if (macas < 12)
{
    resultado = macas * 0.30f;
    Console.WriteLine($"O valor total e de: {resultado}");
} else {
    resultado = macas * 0.25f;
    Console.WriteLine($"O valor total e de: {resultado}");
}