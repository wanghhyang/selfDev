﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperEntity
{
    public class BookStore
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Address Address { get; set; }
    }
}
