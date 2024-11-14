using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 namespace ClasseObjeto.Classes
{
    public class Animal
    {
        public String Nome;
        public String Cor;
        public String raca;
        public int idade = 0;


        public void FazerBarulho(string barulho = "Barulho generico"){

           Console.WriteLine($"Som de um animal qualquer");


        }
        
       public void Envelhecer(){
        
        idade = idade + 1;


       }




        

    }
}
