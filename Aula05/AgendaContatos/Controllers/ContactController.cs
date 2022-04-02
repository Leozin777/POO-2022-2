using System;
using AgendaContatos.Services;

namespace AgendaContatos.Controllers
{
    public class ContactController
    {

        ContactService service = new ContactService();
        public void Menu()
        {

            string operador = string.Empty;

            while (operador != "0")
            {
                Console.WriteLine("Digite 1 para adicionar contato");
                Console.WriteLine("Digite 2 para listar contatos");

                Console.WriteLine("Digite 0 para sair da aplicação");
                operador = Console.ReadLine();

                switch (operador)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.WriteLine("Digite o nome do contato");
                        string name = Console.ReadLine().Trim();

                        Console.WriteLine("Digite o telefone do contato");
                        string phone = Console.ReadLine().Trim();

                        string ret = service.Create(name, phone);

                        Console.WriteLine(ret);
                        break;
                    case "2":
                        Console.WriteLine(service.ListContacts());
                        break;
                    default:
                        Console.WriteLine("invalido");
                        continue;
                }
            }

            

            
        }
    }
}