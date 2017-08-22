using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VmsRawEp.Data;
using VmsRawEp.Models;

namespace VmsRawEp.Controllers
{
    public class VolunteersController : Controller
    {
        private readonly VmsContext _context;

        public VolunteersController(VmsContext context)
        {
            _context = context;    
        }

        // GET: Volunteers
        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["LastNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LastName_desc" : "";
            ViewData["UserIdSortParm"] = sortOrder == "UserId" ? "UserId_desc" : "UserId";
            ViewData["FirstNameSortParm"] = sortOrder == "FirstName" ? "FirstName_desc" : "FirstName";
            ViewData["UserNameSortParm"] = sortOrder == "UserName" ? "UserName_desc" : "UserName";
            ViewData["PasswordSortParm"] = sortOrder == "Password" ? "Password_desc" : "Password";
            ViewData["CenterSortParm"] = sortOrder == "Center" ? "Center_desc" : "Center";
            ViewData["SkillsSortParm"] = sortOrder == "Skills" ? "Skills_desc" : "Skills";
            ViewData["AvailabilitySortParm"] = sortOrder == "Availability" ? "Availability_desc" : "Availability";
            ViewData["StreetAddress1SortParm"] = sortOrder == "StreetAddress1" ? "StreetAddress1_desc" : "StreetAddress1";
            ViewData["StreetAddress2SortParm"] = sortOrder == "StreetAddress2" ? "StreetAddress2_desc" : "StreetAddress2";
            ViewData["CitySortParm"] = sortOrder == "City" ? "City_desc" : "City";
            ViewData["StateSortParm"] = sortOrder == "State" ? "State_desc" : "State";
            ViewData["ZipSortParm"] = sortOrder == "Zip" ? "Zip_desc" : "Zip";
            ViewData["EmailSortParm"] = sortOrder == "Email" ? "Email_desc" : "Email";
            ViewData["EducationSortParm"] = sortOrder == "Education" ? "Education_desc" : "Education";
            ViewData["CurrentLicensesSortParm"] = sortOrder == "CurrentLicenses" ? "CurrentLicenses_desc" : "CurrentLicenses";
            ViewData["EmergencyContactNameSortParm"] = sortOrder == "EmergencyContactName" ? "EmergencyContactName_desc" : "EmergencyContactName";
            ViewData["EmergencyPhoneSortParm"] = sortOrder == "EmergencyPhone" ? "EmergencyPhone_desc" : "EmergencyPhone";
            ViewData["PhoneSecondarySortParm"] = sortOrder == "PhoneSecondary" ? "PhoneSecondary_desc" : "PhoneSecondary";
            ViewData["EmergencyEmailSortParm"] = sortOrder == "EmergencyEmail" ? "EmergencyEmail_desc" : "EmergencyEmail";
            ViewData["EmergencyAddressSortParm"] = sortOrder == "EmergencyAddress" ? "EmergencyAddress_desc" : "EmergencyAddress";
            ViewData["DriversLicenseSortParm"] = sortOrder == "DriversLicense" ? "DriversLicense_desc" : "DriversLicense";
            ViewData["SSNSortParm"] = sortOrder == "SSN" ? "SSN_desc" : "SSN";
            ViewData["ApprovalStatusSortParm"] = sortOrder == "ApprovalStatus" ? "ApprovalStatus_desc" : "ApprovalStatus";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var volunteers = from s in _context.Volunteers
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                volunteers = volunteers.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "LastName_desc":
                    volunteers = volunteers.OrderByDescending(s => s.LastName);
                    break;
                case "UserId_desc":
                    volunteers = volunteers.OrderByDescending(s => s.UserId);
                    break;
                case "UserId":
                    volunteers = volunteers.OrderBy(s => s.UserId);
                    break;

                case "FirstName_desc":
                    volunteers = volunteers.OrderByDescending(s => s.FirstName);
                    break;
                case "FirstName":
                    volunteers = volunteers.OrderBy(s => s.FirstName);
                    break;
                case "UserName_desc":
                    volunteers = volunteers.OrderByDescending(s => s.UserName);
                    break;
                case "UserName":
                    volunteers = volunteers.OrderBy(s => s.UserName);
                    break;
                case "Password_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Password);
                    break;
                case "Password":
                    volunteers = volunteers.OrderBy(s => s.Password);
                    break;
                case "Center_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Center);
                    break;
                case "Center":
                    volunteers = volunteers.OrderBy(s => s.Center);
                    break;
                case "Skills_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Skills);
                    break;
                case "Skills":
                    volunteers = volunteers.OrderBy(s => s.Skills);
                    break;
                case "Availability_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Availability);
                    break;
                case "Availability":
                    volunteers = volunteers.OrderBy(s => s.Availability);
                    break;
                case "StreetAddress1_desc":
                    volunteers = volunteers.OrderByDescending(s => s.StreetAddress1);
                    break;
                case "StreetAddress1":
                    volunteers = volunteers.OrderBy(s => s.StreetAddress1);
                    break;
                case "StreetAddress2_desc":
                    volunteers = volunteers.OrderByDescending(s => s.StreetAddress2);
                    break;
                case "StreetAddress2":
                    volunteers = volunteers.OrderBy(s => s.StreetAddress2);
                    break;
                case "City_desc":
                    volunteers = volunteers.OrderByDescending(s => s.City);
                    break;
                case "City":
                    volunteers = volunteers.OrderBy(s => s.City);
                    break;
                case "State_desc":
                    volunteers = volunteers.OrderByDescending(s => s.State);
                    break;
                case "State":
                    volunteers = volunteers.OrderBy(s => s.State);
                    break;
                case "Zip_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Zip);
                    break;
                case "Zip":
                    volunteers = volunteers.OrderBy(s => s.Zip);
                    break;
                case "Email_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Email);
                    break;
                case "Email":
                    volunteers = volunteers.OrderBy(s => s.Email);
                    break;
                case "Education_desc":
                    volunteers = volunteers.OrderByDescending(s => s.Education);
                    break;
                case "Education":
                    volunteers = volunteers.OrderBy(s => s.Education);
                    break;
                case "CurrentLicenses_desc":
                    volunteers = volunteers.OrderByDescending(s => s.CurrentLicenses);
                    break;
                case "CurrentLicenses":
                    volunteers = volunteers.OrderBy(s => s.CurrentLicenses);
                    break;
                case "EmergencyContactName_desc":
                    volunteers = volunteers.OrderByDescending(s => s.EmergencyContactName);
                    break;
                case "EmergencyContactName":
                    volunteers = volunteers.OrderBy(s => s.EmergencyContactName);
                    break;
                case "EmergencyPhone_desc":
                    volunteers = volunteers.OrderByDescending(s => s.EmergencyPhone);
                    break;
                case "EmergencyPhone":
                    volunteers = volunteers.OrderBy(s => s.EmergencyPhone);
                    break;
                case "PhoneSecondary_desc":
                    volunteers = volunteers.OrderByDescending(s => s.PhoneSecondary);
                    break;
                case "PhoneSecondary":
                    volunteers = volunteers.OrderBy(s => s.PhoneSecondary);
                    break;
                case "EmergencyEmail_desc":
                    volunteers = volunteers.OrderByDescending(s => s.EmergencyEmail);
                    break;
                case "EmergencyEmail":
                    volunteers = volunteers.OrderBy(s => s.EmergencyEmail);
                    break;
                case "EmergencyAddress_desc":
                    volunteers = volunteers.OrderByDescending(s => s.EmergencyAddress);
                    break;
                case "EmergencyAddress":
                    volunteers = volunteers.OrderBy(s => s.EmergencyAddress);
                    break;
                case "DriversLicense_desc":
                    volunteers = volunteers.OrderByDescending(s => s.DriversLicense);
                    break;
                case "DriversLicense":
                    volunteers = volunteers.OrderBy(s => s.DriversLicense);
                    break;
                case "SSN_desc":
                    volunteers = volunteers.OrderByDescending(s => s.SSN);
                    break;
                case "SSN":
                    volunteers = volunteers.OrderBy(s => s.SSN);
                    break;
                case "ApprovalStatus_desc":
                    volunteers = volunteers.OrderByDescending(s => s.ApprovalStatus);
                    break;
                case "ApprovalStatus":
                    volunteers = volunteers.OrderBy(s => s.ApprovalStatus);
                    break;
       
                default:
                    volunteers = volunteers.OrderBy(s => s.LastName);
                    break;
            }
            int pageSize = 3;
            return View(await PaginatedList<Volunteer>.CreateAsync(volunteers.AsNoTracking(), page ?? 1, pageSize));
        }

        // GET: Volunteers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        // GET: Volunteers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Volunteers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,FirstName,LastName,UserName,Password,Center,Skills,Availability,StreetAddress1,StreetAddress2,City,State,Zip,Email,Education,CurrentLicenses,EmergencyContactName,EmergencyPhone,PhoneSecondary,EmergencyEmail,EmergencyAddress,DriversLicense,SSN,ApprovalStatus")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(volunteer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(volunteer);
        }

        // GET: Volunteers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers.SingleOrDefaultAsync(m => m.Id == id);
            if (volunteer == null)
            {
                return NotFound();
            }
            return View(volunteer);
        }

        // POST: Volunteers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,FirstName,LastName,UserName,Password,Center,Skills,Availability,StreetAddress1,StreetAddress2,City,State,Zip,Email,Education,CurrentLicenses,EmergencyContactName,EmergencyPhone,PhoneSecondary,EmergencyEmail,EmergencyAddress,DriversLicense,SSN,ApprovalStatus")] Volunteer volunteer)
        {
            if (id != volunteer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(volunteer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VolunteerExists(volunteer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(volunteer);
        }

        // GET: Volunteers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        // POST: Volunteers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var volunteer = await _context.Volunteers.SingleOrDefaultAsync(m => m.Id == id);
            _context.Volunteers.Remove(volunteer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VolunteerExists(int id)
        {
            return _context.Volunteers.Any(e => e.Id == id);
        }
    }
}
