﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataLibrary.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
