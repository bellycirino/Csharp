Console.WriteLine(@"
+....................................+
|         Bem-Vindo ao programa      |
|         de esporte                 |
+....................................+
");


int qtdMulher = 0;
int qtdHomem = 0;
int qtdEsporte = 0;
int qtdNaoGosta = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa");
int Entrevistados = int.Parse (Console.ReadLine()!);

for (int i =1; 1 <= Entrevistados; i++)
{
    Console.WriteLine($"Qual o seu sexo? f/m?");
    string sexo = Console.ReadLine();

    if(sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }

Console.WriteLine($"Voce gosta de esporte? s/n?");
      string esporte = Console.ReadLine ();

    if (esporte == "s")
    {
        qtdEsporte ++;
    }  
    else 
    {
        qtdNaoGosta ++;
    }
  
 //fim do for 

Console.WriteLine($"Quatidade de Mulheres: {qtdMulher}"); 
Console.WriteLine($"Quatidade de Homem: {qtdHomem}"); 
Console.WriteLine($"Quatidade de Entrevistados: {qtdMulher + qtdHomem}"); 
Console.WriteLine($"Quatidade de Esporte: {qtdEsporte}");
Console.WriteLine($"Quatidade de nao gostam de esporte: {qtdNaoGosta}");  















}