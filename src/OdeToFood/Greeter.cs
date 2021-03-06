﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetGreeter();
    }
    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration configuration)
        {
             _greeting = configuration["Greeting"];
        }

        public string GetGreeter()
        {
            return _greeting;
        }
    }
}
