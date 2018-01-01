using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [StringLength(255)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public MembershipType MembershipType { get; set; }

        //[Display(Name = "Membership Type")]
        //public byte MembershipTypeId { get; set; }

        //[Display(Name = "Date of Birth")]
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToCustomer { get; set; }
    }
}