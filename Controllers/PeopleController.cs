using SPA.Data;
using SPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPA.Controllers
{
    public class PeopleController : ApiController
    {
        SPAContext db=new SPAContext();
        //get: get info from db
        public IEnumerable<Person> GetPeople()
        {
            return db.People;
        }
        public Person GetByID(int id)
        {
            return db.People.Find(id);
        }
        //post: insert into db
        public void PostPerson(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
        }
        //put: edit and update data
        public void PutPerson(int id, Person person)
        {
            if(id==person.ID)
            {
                db.Entry(person).State=System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void DeletePerson(int id) 
        {
            var person = GetByID(id);
            db.Entry(person).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
