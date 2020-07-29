using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8.Models
{
    public class PhoneDictionaryContext : DbContext , IRepository<User>
    {
        public PhoneDictionaryContext(DbContextOptions<PhoneDictionaryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<User> Users { get; set; }

        public User Add(User item)
        {
            this.Users.Add(item);
            this.SaveChanges();
            return item;
        }

        public IEnumerable<User> GetAllPhones()
        {
            var sortedPhones = this.Users.Select(n => n).OrderBy(n => n.Name);
            return sortedPhones;
        }

        public User Remove(string id)
        {
            int ID;
            if (Int32.TryParse(id, out ID))
            {

                var checkExistPhone = Get(ID);
                if(checkExistPhone != null)
                {
                    this.Users.Remove(checkExistPhone);
                    this.SaveChanges();
                    return checkExistPhone;
                }
            }
            return null;
        }

        public User Update(User item)
        {
            var phone = Get(item.Id);
            if (phone != null)
            {
                phone.Name = item.Name;
                phone.phoneNumber = item.phoneNumber;
                this.Users.Attach(phone);
                //db.Entry(phone).State = EntityState.Modified;
                this.SaveChanges();
                return phone;
            }
            return null;
        }

        public User Get(int ID)
        {
            return this.Users.FirstOrDefault(t => t.Id == ID);
        }

    }

}
