﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using culqi.net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
   
    public class GenericController : Controller
    {
        Security security = null;
  
        public Security securityKeys()
        {
           
            security = new Security();
            security.public_key = "pk_test_90667d0a57d45c48";
            security.secret_key = "sk_test_1573b0e8079863ff";

            return security;
        }

    }
}

