
namespace RPGPOO.Classes
{
    public class Personagem 
    { public string Nome;
        public int Idade;
        public string Armadura;
        public string IA;

    public void Atacar () 
    {
        Console.WriteLine($"O {Nome} atacou!");
        
    }

    public void Defender () 
    {
        Console.WriteLine($"O {Nome} defendeu!");
        
    }

    public void RestaurarArmadura () 
    {
        Console.WriteLine($"O {Nome} restaurou a armadura!");
        


    }
}
}