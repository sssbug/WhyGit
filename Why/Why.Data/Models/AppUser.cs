using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;

namespace Why.Data.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Chats = new HashSet<Chat>();
        }
        public virtual ICollection<Chat> Chats { get; set; }
    }
}
