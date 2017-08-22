using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VmsRawEp.Models;

namespace VmsRawEp.Data
{
    public class DbInitializer
    {
        public static void Initialize(VmsContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Volunteers.Any())
            {
                return;   // DB has been seeded
            }

            var volunteers = new Volunteer[]
            {
            new Volunteer{UserId = new Guid("61612ca5-deb8-4cff-9014-985c1e95edcb"),FirstName = "William", LastName = "Shatner"
        , Password = "iXAOHG", Center = "Rohan-Anderson"
        , Skills = "Urgent Care", Availability = new DateTime(2018, 03, 22)
        , StreetAddress1 = "The Bridge", StreetAddress2 = "Starship Enterprise NCC-1701"
        , City = "Riverside", State = "IA", Zip = "65432-0123"
        , Email = "the.captain@starfleet.com", Education ="quam a odio in hac habitasse platea "
        , CurrentLicenses= "ipsum dolor sit amet consectetuer", EmergencyContactName = "Skyler Goldring"
        , EmergencyPhone = "765-432-1098", PhoneSecondary = "654-321-0987"
        , EmergencyEmail = "sgoldring0@imgur.com", EmergencyAddress = "02459 Village Parkway"
        , DriversLicense = "520252174-X", SSN = "159-93-2468", ApprovalStatus = "Approved"}

        ,new Volunteer { UserId = new Guid("61612ca5-deb8-4cff-9014-985c1e95edcb")
        , FirstName = "Lana"
        , LastName = "Glasspoole"
        , Password = "lglasspoole0"
        , Center = "Konopelski, Brakus and Dach"
        , Skills = "Urgent Care"
        , Availability = new DateTime(2018, 09, 22)
        , StreetAddress1 = "71 Cardinal Plaza"
        , StreetAddress2 = "Starship Enterprise NCC-1701"
        , City = "Riverside"
                , State = "IA"
        , Zip = "65432-0123"
        , Email = "lglasspoole0@amazonaws.com"
        , Education ="quam a odio in hac habitasse platea "
        , CurrentLicenses= "dolor sit amet consectetuer"
        , EmergencyContactName = "Lana Glasspoole"
        , EmergencyPhone = "765-432-1898"
        , PhoneSecondary = "954-321-0987"
        , EmergencyEmail = "lglasspoole0@sakura.ne.jp"
        , EmergencyAddress = "5411 Coleman Court"
        , DriversLicense = "520252174-X"
        , SSN = "691239082-X"
        , ApprovalStatus = "Approved"}

        ,new Volunteer { UserId = new Guid("61612ca5-deb8-4cff-9014-985c1e95edcb")
        , FirstName = "Malorie"
        , LastName = "Madgwich"
        , Password = "mmadgwich1"
        , Center = "Konopelski, Brakus and Dach"
        , Skills = "Foreign Languages"
        , Availability = new DateTime(2018, 11, 22)
        , StreetAddress1 = "19989 Crest Line Point"
        , StreetAddress2 = "66 Glacier Hill"
        , City = "Washington"
        , State = "District of Columbia"
        , Zip = "20210-0123"
        , Email = "mmadgwich1@123-reg.co.uk"
        , Education ="in hac habitasse platea quam a odio"
        , CurrentLicenses= "amet consectetuer dolor sit"
        , EmergencyContactName = "Malorie Madgwich"
        , EmergencyPhone = "1-(202)795-8628"
        , PhoneSecondary = "1-(817)456-8636"
        , EmergencyEmail = "mmadgwich1@samsung.com"
        , EmergencyAddress = "185 Roth Terrace"
        , DriversLicense = "126424148-8"
        , SSN = "744-66-2938"
        , ApprovalStatus = "Disapproved"}

,new Volunteer { UserId = new Guid("61612ca5-deb8-4cff-9014-985c1e95edcb")
        , FirstName = "Cori"
        , LastName = "Hamments"
        , Password = "chamments2"
        , Center = "Littel, Walter and Vandervort"
        , Skills = "Upholstery"
        , Availability = new DateTime(2018, 11, 22)
        , StreetAddress1 = "071 Burrows Park"
        , StreetAddress2 = "92600 Moose Parkway"
        , City = "Washington"
                , State = "District of Columbia"
        , Zip = "20210-0123"
        , Email = "chamments2@tinypic.com"
        , Education ="wein hac habitasse platea quam a odio"
        , CurrentLicenses= "lawe amet consectetuer dolor sit"
        , EmergencyContactName = "Cori Hamments"
        , EmergencyPhone = "1-(716)976-5681"
        , PhoneSecondary = "1-(770)828-3833"
        , EmergencyEmail = "chamments2@slideshare.net"
        , EmergencyAddress = "185 Roth Terrace 7 Clemons Lane"
        , DriversLicense = "647779067-X"
        , SSN = "349-70-7558"
        , ApprovalStatus = "Pending Approval"}

,new Volunteer { UserId = new Guid("61612ca5-deb8-4cff-9014-985c1e95edcb")
        , FirstName = "Dylan"
        , LastName = "Cudde"
        , Password = "dcudde3"
        , Center = "Angry Red Planet"
        , Skills = "Upholstery"
        , Availability = new DateTime(2018, 05, 12)
        , StreetAddress1 = "28129 Haas Street"
        , StreetAddress2 = "78156 Ridgeview"
        , City = "Greenville"
                , State = "South Carolina"
        , Zip = "29610-0125"
        , Email = "dcudde3@macromedia.com"
        , Education ="platea quam habitasse a odio"
        , CurrentLicenses= "laconsectetuer amet consectetuer"
        , EmergencyContactName = "Dylan Cudde"
        , EmergencyPhone = "1-(864)379-4863"
        , PhoneSecondary = "1-(404)755-8955"
        , EmergencyEmail = "dcudde3@oakley.com"
        , EmergencyAddress = "0581 Fairfield Center"
        , DriversLicense = "647779067-X"
        , SSN = "856612196-1"
        , ApprovalStatus = "inactive"}
            };
            foreach (Volunteer s in volunteers)
            {
                context.Volunteers.Add(s);
            }
            context.SaveChanges();

            
        }
    }
}
