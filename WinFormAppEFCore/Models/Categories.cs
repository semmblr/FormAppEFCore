﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAppEFCore.Models
{
    class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
        public IList<Products> Products { get; set; }
    }
}
