using System;
using AgendaContatos.Controllers;
using AgendaContatos.Services;

namespace AgendaContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ContactController control = new ContactController();

            control.Menu();
        }
    }
}
