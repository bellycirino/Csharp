 using ClasseObjeto.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao programa Zoosharp **");
Console.WriteLine();

Animal cachorro = new Animal ();

cachorro.Nome = "Floquinho";
cachorro.raca = "Poodle";
cachorro.Cor = "Branco";
cachorro.idade = 10; 

Animal cachorrinhodabrito = new Animal ();

cachorro.Nome = "Max";
cachorro.raca = "American bully";
cachorro.Cor = "Preto";
cachorro.idade = 4; 

Animal peixeDokaue = new Animal ();

cachorro.Nome = "Luna";
cachorro.raca = "Telescopio";
cachorro.Cor = "Branca";
cachorro.idade = 10; 

// Console.WriteLine(@$"Animal 1:

//  Nome : {cachorrinho.Nome}
//  raca : {cachorrinho.raca}
//  Cor : {cachorrinho.Cor}
//  Idade: {cachorrinho.idade}


// ");

// Console.WriteLine(@$"Animal 2:

//  Nome : {cachorrinhodabrito.Nome}
//  raca : {cachorrinhodabrito.raca}
//  Cor : {cachorrinhodabrito.Cor}
//  Idade: {cachorrinhodabrito.idade}


// ");

// Console.WriteLine(@$"Animal 3:

//  Nome : {peixeDokaue.Nome}
//  raca : {peixeDokaue.raca}
//  Cor : {peixeDokaue.Cor}
//  Idade: {peixeDokaue.idade}


// ");

cachorro.FazerBarulho("au au");
Console.WriteLine($"idada de {cachorro.Nome} e {cachorro.idade}");

cachorro.Envelhecer();
Console.WriteLine($" Nova idada de {cachorro.Nome} e {cachorro.idade}");

cachorrinhodabrito.FazerBarulho("ow ow");
Console.WriteLine($"idada de {cachorrinhodabrito.Nome} e {cachorrinhodabrito.idade}");

peixeDokaue.FazerBarulho("glu glu");
Console.WriteLine($"idada de {peixeDokaue.Nome} e {peixeDokaue.idade}");




