﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day20UserRegistration
{
    public class EmailSample
    {
        public string email;

        public EmailSample(string email)
        {
            this.email = email;
        }

        public string ValidateEmail()
        {
            string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

            if (Regex.IsMatch(email, pattern))
            {
                return email;
            }
            else
            {
                return null;
            }
            if (Regex.IsMatch(email, pattern))
            {
                return email;
            }
            else
            {
                return null;
            }
        }

    }
}
