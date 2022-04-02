using System.Text;
using AgendaContatos.Data;
using AgendaContatos.Domain;

namespace AgendaContatos.Services
{
    public class ContactService
    {
        ContactRepository minhaAgenda = new ContactRepository();

        public int GetNextId() { return minhaAgenda.GetAll().Count + 1; }

        public string Create(string name, string phone)
        {
            minhaAgenda.Save(new Contact(GetNextId(), name, phone));
            return "Contato criado com sucesso.";
        }

        public string ListContacts()
        {
            var builder = new StringBuilder();
            var listContacts = minhaAgenda.GetAll();
            var qtdContatos = listContacts.Count;

            if (qtdContatos == 0)
                builder.AppendLine("Lista vazia");
            else
            {
                foreach (Contact contact in listContacts)
                {
                    builder.AppendLine($"nome: {contact.Name}   Id: {contact.Id}");
                }
            }
            return builder.ToString();
        }
           
    }
}