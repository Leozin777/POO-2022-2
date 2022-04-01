using System.Collections.Generic;
using AgendaContatos.Domain;

namespace AgendaContatos.Data
{
    public class ContactRepository
    {
        private List<Contact> listContacts = new List<Contact>();

        public List<Contact> GetAll()
        {
            return listContacts;
        }

        public Contact GetById(int id)
        {

            // foreach (var item in listaDeContatos)
            // {
            //     if(item.Id == id)
            //     {
            //         return item;
            //     }
                    
            // }

            // for (int i = 0; i < listaDeContatos.Count; i++)
            // {
            //     if(listaDeContatos[i].Id == id)
            //     {
            //         return listaDeContatos[0];
            //     }
            // }

            return listContacts.Find(p=>p.Id == id);

            
        }

        public void Save(Contact contact)
        {
            listContacts.Add(contact);
        }

        public void Update(Contact contato)
        {
            var edit = GetById(contato.Id);

            edit.Name = contato.Name;
            edit.Phone = contato.Phone;
        }

    }
}