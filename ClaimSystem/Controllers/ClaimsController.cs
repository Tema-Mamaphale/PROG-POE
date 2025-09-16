using Microsoft.AspNetCore.Mvc;
using ClaimSystem.Models;

namespace ClaimSystem.Controllers
{

    public class ClaimsController : Controller
    {
        // A fake in memroty datavase so this is a static list for now. so that i  can show som data without the real databse yet.
        private static readonly List<Claim> _demo = new()
        {
            new Claim { Id=1, LecturerName="M. Machaba", Month="October 2025", HoursWorked=18, HourlyRate=650, Status=ClaimStatus.PendingReview, AttachmentFileName="Timesheet_Oct.pdf" },
            new Claim { Id=2, LecturerName="L. Tema", Month="November 2025", HoursWorked=10, HourlyRate=700, Status=ClaimStatus.Submitted }
        };

        // redirects the user to the submit page instead of showing a blank page
        public IActionResult Index() => RedirectToAction(nameof(Submit));

        // auto fill for month property 
        [HttpGet]
        public IActionResult Submit() => View(new Claim { Month = "October 2025" });

        [HttpGet]
        public IActionResult Review()
        {
            var pending = _demo
                .Where(c => c.Status is ClaimStatus.Submitted or ClaimStatus.PendingReview)
                .ToList();                          
            return View(pending);                   
        }

        [HttpGet]
        public IActionResult Status(int id = 0)
        {
            var claim = _demo.FirstOrDefault(c => c.Id == id) ?? new Claim
            {
                LecturerName = "—",
                Month = "—",
                HoursWorked = 0,
                HourlyRate = 0,
                Status = ClaimStatus.Submitted
            };

            // this sends the claim to the view for display 
            return View(claim);
        }
    }
}