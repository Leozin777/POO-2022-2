using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace NomeDoPRojeto
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            var pessoa3 = new List<Pessoa>()
            { 
                new Pessoa(1,"Cassio"),
                new Pessoa(2,"Rafaela")
            };

            

            Pessoa pessoa = new Pessoa(101,"João");
            Pessoa pessoa2 = new Pessoa(102,"rafael");

            pessoas.Add(pessoa);
            pessoas.Add(pessoa2);

            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine(pessoas[i].Nome);
            }
            
            foreach (var item in pessoas)
            {
                Console.WriteLine(item.Nome);
            }






        }
    }
}
