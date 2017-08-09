using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech.Consultancy.Model
{
    public class EmployeeDetailsModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailId { get; set; }
        public long PhoneNumber { get; set; }
        public long AlternatePhoneNumber { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String HomeCountry { get; set; }
        public String CurrentCountry { get; set; }
        public long ZipCode { get; set; }
    }
}
