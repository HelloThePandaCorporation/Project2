﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_API_Perkantoran.Models
{
    public class Role
    {

        [Key]
        public int id { get; set; }
        public string Name { get; set; }
    }
}
