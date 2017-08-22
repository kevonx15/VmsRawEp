using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VmsRawEp.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Center { get; set; }
        public string Skills { get; set; }
        public DateTime Availability { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string CurrentLicenses { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyPhone { get; set; }
        public string PhoneSecondary { get; set; }
        public string EmergencyEmail { get; set; }
        public string EmergencyAddress { get; set; }
        public string DriversLicense { get; set; }
        public string SSN { get; set; }
        public string ApprovalStatus { get; set; }
    }
}
