//Faça um programa que carregue dois vetores de 10 elementos numéricos cada um e imprima a intercalação desses dois

Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|            DE  VETORES               |
+--------------------------------------+
");

int [] vetor1 = {5,6,5,7,9,11,13,15,17,19};
int [] vetor2 = {0,0,0,0,0,0,0,0,0,0,};

for (int i = 0; i < vetor1.Length; i++)
{
    Console.WriteLine (vetor1 [i]);

    Console.WriteLine (vetor2 [i]);
}