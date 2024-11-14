using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrutores.Classe.Apredizagem
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Idade { get; set; } 

        public string CPF { get; set; }

        public string Peso { get; set; } 

        public string Altura { get; set; }

        public void envelhecer (){
            Idade ++;
        } 

        public void engordar (float _kg){
            Peso = Peso - _kg;
 
        }

    
    }
}