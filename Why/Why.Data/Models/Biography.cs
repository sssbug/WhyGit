﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Why.Data.Models
{
    public class Chat
    {
        [Key]
        public int ChatId { get; set; }
        public int ChatFirstUserName { get; set; }
        public int ChatSecondUserName { get; set; }
        public string ChatUsersName { get; set; }
        public string ChatTitle { get; set; }
        public string ChatContent { get; set; }
        public User User { get; set; }
    }
}
