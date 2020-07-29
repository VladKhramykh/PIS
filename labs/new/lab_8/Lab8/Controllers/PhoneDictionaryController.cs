using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab8.Controllers
{
    [Route("dictApi")]
    [ApiController]
    public class PhoneDictionaryController : ControllerBase
    {
        IRepository<User> phoneRepository;
        public PhoneDictionaryController(IRepository<User> rep)
        {
            phoneRepository = rep;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(phoneRepository.GetAllPhones().ToList());
        }

        [HttpGet("{id:int}")]
        public ActionResult<User> Get(int id)
        {
            User phone =  phoneRepository.Get(id);
            if (phone == null)
                return NoContent();
            return Ok(phone);
        }

        [HttpPost]
        public ActionResult<User> Post(User phone)
        {
            return phoneRepository.Add(phone);
        }

        [HttpPut]
        public ActionResult<User> Put(User phone)
        {
            return phoneRepository.Update(phone);
        }

        [HttpDelete("{id}")]
        [HttpDelete]
        public ActionResult<User> Delete(string id)
        {
            return phoneRepository.Remove(id);
        }


    }
}