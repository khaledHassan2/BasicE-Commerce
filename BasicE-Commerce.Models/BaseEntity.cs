﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }= default!;
        public bool IsDeleted { get; set; }= false;
    }
}
