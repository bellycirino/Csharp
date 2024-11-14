using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrutores.Classe.Apredizagem
{
    public abstract class Veiculo
    {
        public string marca;

        public string modelo; 

        public string cor; 

        public int potencia; 

        public int passageiros;  

        public void Ligar (){

            Console.WriteLine($"carro ligar");
        }













    }
}