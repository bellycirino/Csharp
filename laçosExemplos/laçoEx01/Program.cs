Console.WriteLine(@"
+....................................+
|         Bem-Vindo ao programa      |
|           contador de pessoa       |
+....................................+
");

int homem = 0;
int mulher = 0;
string sexo;

for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine($"Qual o seu sexo");
    sexo = Console.ReadLine();

    if(sexo == "feminino"){
        mulher++;
    }else{
        homem+;
    }

} 

Console.WriteLine($"Quatidade de homem: {homem}");
Console.WriteLine($"Quatidade de mulher: {mulher}");

