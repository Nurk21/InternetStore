using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Common.Models
{
    public class User : BaseUser
    {
        public User(Guid Id, string name, string login, string password)
        {
            this.Id = Id;
            Name = name;
            CreatedAt = DateTime.UtcNow;
            Login = login;
            Password = password;
        }
        public DateTime? LasrPurchaseDate { get; set; }
    }
}