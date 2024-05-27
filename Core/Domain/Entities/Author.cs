﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author:BaseEntity
    {
        public User User { get; set; }
        public List<Article> Articles { get; set; }
    }
}
