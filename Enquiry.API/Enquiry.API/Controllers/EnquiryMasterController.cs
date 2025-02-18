using Enquiry.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnquiryMasterController : ControllerBase
    {
        private readonly EnquiryDbContext _context;

        public EnquiryMasterController(EnquiryDbContext context)
        {
            _context = context;
        }

        //[HttpGet("GetAllStatus")]
        //public List<EnquiryStatus> GetEnquiryStatus()
        //{
           
        //}
    }
}
