using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Database;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class UserController : ApiController
    {
        /*
        [HttpGet]
        public string Greet(string name)
        {
            return "Welcome " + name;
        }
        */
        DatabaseContext db = new DatabaseContext();

        public IEnumerable<User> GetUsers()
        {
            return db.Users.ToList();
        }
        public User GetUser(int id)
        {
            return db.Users.Find(id);
        }

        [HttpPost]
        public HttpRequestMessage AddUser(User model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch(Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
        }

        [HttpPost]
        public HttpRequestMessage UpdateUser(User model)
        {
            try
            {
                if(IDictionary == model.UserId)
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    HttpResponseMessage reponse = new HttpResponseMessage(HttpStatusCode.OK);
                    return reponse;

                }
                else
                {
                    HttpResponseMessage reponse = new HttpResponseMessage(HttpStatusCode.NotModified);
                    return reponse;
                }
               
            }
            catch (Exception ex)
            {
                HttpResponseMessage reponse = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
        }
        public HttpResponseMessage DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if(user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                HttpResponseMessage reponse = new HttpResponseMessage(HttpStatusCode.OK);
                return reponse;
            }
            else
            {
                HttpResponseMessage reponse = new HttpResponseMessage(HttpStatusCode.NotFound);
                return reponse;
            }
        }
    }
}
