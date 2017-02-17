using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        //1.Add-Migration AddIsSubscribedToCustomer
        public bool  IsSubscribedToNewsLetter { get; set; }

        //this is the navigation Bar
        //2.Add-Migration MembershipType
        public MembershipType MembershipType { get; set; }

        //foreign key of Membership
        public byte  MembershipTypeId { get; set; }
    }
}