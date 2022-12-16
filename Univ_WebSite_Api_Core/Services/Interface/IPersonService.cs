using Univ_WebSite_Api_Core.Appcode;
using Univ_WebSite_Api_Core.Models;

namespace Univ_WebSite_Api_Core.Services.Interface
{
    public interface IPersonService
    {
        public List<Person> SelectAll();


        public Person SelectByID(int personID);


        public int Insert(Person person);


        public int Update(Person person);


        public int Delete(int personID);
       

    }
}
