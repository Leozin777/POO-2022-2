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
    }
}