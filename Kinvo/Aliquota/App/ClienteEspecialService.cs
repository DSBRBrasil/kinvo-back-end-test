﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aliquota.App.Interfaces;
using Aliquota.CrossCuting;
using Aliquota.Domain;

namespace Aliquota.App
{
   public  class ClienteEspecialService:ClienteServiceTemplate
    {
        public ClienteEspecialService(Cliente cliente) : base(cliente)
        {
        }

 
    }
}
