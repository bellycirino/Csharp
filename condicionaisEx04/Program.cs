﻿Console.WriteLine(@"
+....................................+
|         Bem- Vindo ao programa     |
|         validacao de senha         |
+....................................+
");

Console.WriteLine($"Digite a senha");
int senha = int.Parse (Console.ReadLine());

if (senha == 1234) 
{
    Console.WriteLine($"Acesso Permitido.");
} else {
    Console.WriteLine($"Acesso Negado.");
}