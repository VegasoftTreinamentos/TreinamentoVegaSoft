﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sergio.Saude.Web.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }

        public string Nome {get; set; }

        public string Email { get; set; }

    }
}