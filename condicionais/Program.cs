Console.WriteLine(@"
+....................................+
|         Bem- Vindo ao programa     |
|             Carteira               |
+....................................+
");

float precoProduto = 200;
float minhaCarteira = 350;

if (minhaCarteira >= precoProduto) 

{
    Console.WriteLine($"Sim, voce pode comprar o preduto :)");
}
else {
    Console.WriteLine($"Nao, voce está sem saldo");
} 


