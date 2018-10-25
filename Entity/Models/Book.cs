﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTimeOffset ReleaseDate { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }
    }
}
