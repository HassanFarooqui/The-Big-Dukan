using System;
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

        public int CellNo { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }


        public List<string> userList = new List<string>
        {
            "Vendor",
            "Customer"
        };



    }
}