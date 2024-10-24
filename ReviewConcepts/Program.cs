Console.WriteLine(@"
+....................................+
|         Programa De Cadastro       |
+....................................+
| Iremos, iniciar seu cadastro       |
+....................................+
");

/*Console.WriteLine($"Olá, Seja Bem-Vindo");
Console.WriteLine($"Iremos, iniciar o seu cadastro");*/


Console.WriteLine($"Olá, Digite seu Nome:");
string Nome = Console.ReadLine()!;

Console.WriteLine($"Olá, {Nome}, Digite seu Sobrenome:");
string Sobrenome = Console.ReadLine()!;

Console.WriteLine($"Em que ano voce nasceu");
int anoNascimento = int.Parse(Console.ReadLine()!); 
int anoAtual = DateTime.Now.Year; 
int idade = anoAtual - anoNascimento;

Console.WriteLine($"Olá, Digite seu Email:");
string Email = Console.ReadLine()!;

Console.WriteLine($"Olá, Digite seu Telefone:");
string Telefone = Console.ReadLine()!;

Console.WriteLine($"Olá, Digite seu Cpf:");
string Cpf = Console.ReadLine()!;

Console.WriteLine($"Olá, Digite seu Endereço:");
string Endereço = Console.ReadLine()!; 

Console.WriteLine($"Olá, Qual é seu Estado Civil");
string Casado = Console.ReadLine()!; 

Console.Clear();

Console.WriteLine($"Exibir dados");

Console.WriteLine($"{Email}\n");
Console.WriteLine($"{Telefone}\n");
Console.WriteLine($"{Cpf}\n");
Console.WriteLine($"{Endereço}\n");
Console.WriteLine($"{Casado}\n");
Console.WriteLine($"Obrigado: {Nome} {Sobrenome}, cadastro concluido\n");