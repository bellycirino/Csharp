Console.WriteLine(@"
+....................................+
|         Bem- Vindo ao programa     |
|             Triangulo              |
+....................................+
");

Console.WriteLine("primeiro lado:");
      float lado1 = float.Parse(Console.ReadLine()!);
      
Console.WriteLine("segundo lado:");
      float lado2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("terceiro lado:");
      float lado3 = float.Parse(Console.ReadLine()!);

if (lado1 == lado2 && lado2 == lado3) 
{
    Console.WriteLine("Triangulo Equilatero");
}     
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("Isoscele");
} 
else
{
    Console.WriteLine("Triangulo Escalo");
}