using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Why.Data.Models
{
    public class Thumb
    {
        [Key]
        public int ThumbId { get; set; }
        public string ThumbName { get; set; }
        public DateTime Date { get; set; }
        public string UsersName { get; set; }
        public int UserssId { get; set; }
        public User User { get; set; }

        public List<Biography> ThumbBiography { get; set; }

    }
}
