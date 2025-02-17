﻿using Microsoft.EntityFrameworkCore;

namespace Enquiry.API.Model
{
    public class EnquiryDbContext : DbContext
    {
        public EnquiryDbContext(DbContextOptions<EnquiryDbContext> options)
            : base(options)
        {
        }

        public DbSet<EnquiryStatus> EnquiryStatuses { get; set; }
        public DbSet<EnquiryType> EnquiryTypes { get; set; }
        public DbSet<EnquiryModel> EnquiryModels { get; set; }
    }
}
