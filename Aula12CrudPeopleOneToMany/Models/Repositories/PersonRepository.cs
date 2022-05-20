using System.Collections.Generic;
using System.Linq;
using Aula11CrudPeople.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace Aula11CrudPeople.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Person person)
        {
            if(person.City.Id>0)
                person.City = 
                context.Cities
                    .SingleOrDefault(x=>x.Id == person.City.Id &&);
            
            context.Add(person);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return context.People
                .Include(c=>c.City).ToList();
        }

        public Person GetById(int id)
        {
            return context.People.Include(c=>c.City).SingleOrDefault(i=>i.Id == id);
            // from cities inner join people on p.city_id = c.id
        }

        public void Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}