using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mubee.Models
{
    public class Customer
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}