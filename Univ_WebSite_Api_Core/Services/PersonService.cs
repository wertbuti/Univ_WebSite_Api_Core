using Univ_WebSite_Api_Core.Appcode;
using Univ_WebSite_Api_Core.Models;
using Univ_WebSite_Api_Core.Services.Interface;

namespace Univ_WebSite_Api_Core.Services
{
    public class PersonService :IPersonService
    {
        UnivEntities _univEntities;

        public PersonService(UnivEntities univEntities)
        {
            _univEntities = univEntities;
        }

        public List<Person> SelectAll()
        {
            List<Person> personList = new List<Person>();

            personList = _univEntities.Person.ToList();

            return personList;
        }

        public Person SelectByID(int personID)
        {
            Person person = new Person();

            person = _univEntities.Person.Where(x => x.PersonID == personID).FirstOrDefault();

            return person;
        }

        public int Insert(Person person)
        {
            int result = 0;

            _univEntities.Add(person);

            result = _univEntities.SaveChanges();


            return result;
        }

        public int Update(Person person)
        {
            int result = 0;

            _univEntities.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            result = _univEntities.SaveChanges();


            return result;
        }

        public int Delete(int personID)
        {
            int result = 0;

            Person person  = new Person() { PersonID = personID };

            _univEntities.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

            result = _univEntities.SaveChanges();


            return result;
        }


    }
}
