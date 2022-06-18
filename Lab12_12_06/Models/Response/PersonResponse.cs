using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAEA_LAB13_WebAPI.Models.Response
{
    public class PersonResponse
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
    }
}