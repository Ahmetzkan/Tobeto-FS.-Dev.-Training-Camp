﻿using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class EgovernmenentVerificationService:IVerificationService
    {
        public bool Save(User user)
        {
            Console.WriteLine("Egovernment is added");
            return true;
        }

        public bool Verify(User user)
        {
            Console.WriteLine("E government is verified");
            return user.TcNo.Length == 11 && user.BirthYear > 1900;
        }

       
    }
}
