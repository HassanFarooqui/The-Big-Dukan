﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBigDukan.Models
{
    public class SignUpModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string CellNo { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }
        public HttpPostedFileBase Image_new { get; set; }

    }
}