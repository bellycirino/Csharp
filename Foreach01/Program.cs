string[] frutas = {"Melancia","Carambola","Maracuja",
"Morango","Limao","Jabuticaba","Abacate","Kiwi",
"Acerola","Pinha","Lichia","Pitaya","Pessego","Banana"      
};

Console.WriteLine($"Sua sacola contem {frutas.Legth} frutas!");

//percorre todo o array e exibe cada fruta
foreach (string f in frutas) 
{
    Console.WriteLine ($"{f}, ");
}

Console.WriteLine();

//Crie um novo projeto console
//Carregue um array fixo de 10 numeros
// Utilize um laço foreach para imprimir o dobro de cada numero do array