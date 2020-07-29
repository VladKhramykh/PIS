using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication.Db.msImpl;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    
    public class DictController : ApiController
    {
        private UserContextFactory userFactory = new UserContextFactory();

        // GET: Dict

        public IEnumerable<User> GetAll()
        {
            List<User> users = userFactory.GetAll();
            users.Sort((u1, u2) => u1.Name.CompareTo(u2.Name));
            return users;
        }

        [HttpPost]
        public User Create([FromBody]User user)
        {
            userFactory.Create(user);
            return user;
        }

        [HttpGet]
        public User Update([FromBody] User user)
        {
            userFactory.Update(user);
            return user;
        }

        [HttpDelete]
        public User Delete (long id)
        {
            userFactory.Delete(id);
            return userFactory.GetOneById(id);
        }
        
    }
}