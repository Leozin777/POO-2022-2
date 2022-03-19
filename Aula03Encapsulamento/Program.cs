using System;
using Aula03Encapsulamento.Domain;

namespace Aula03Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

           WriteMsg("criar o objeto mochila");

           Mochila mp = new Mochila(1,"Mochila de notebook", 199,10,eCor.Amarelo);
           WriteMsg("Nome: " + mp.Descricao + 
                    "Cor: " + mp.Cor); 

            WriteMsg($"PReco:, {mp.Preco}");

            Item celular = new Item(100,"Nokia 3030");
            Item caneta = new Item(102,"Caneta de quadro branco");
            
            mp.Itens.Add(celular);
            mp.Itens.Add(caneta);
            
            WriteMsg("Nome: " + mp.Descricao);
            WriteMsg("itens");
            foreach (var item in mp.Itens)
            {
                WriteMsg(item.Nome);
            } 



            

        }

        private static void WriteMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
