using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCRUD.Models
{
    public class Address
    {
        public int ID { get; set; }
	    public string StreetAddress { get; set; }
	    public string City { get; set; }
	    public string PostCode { get; set; }
        public int StudentID { get; set; }
    }
}