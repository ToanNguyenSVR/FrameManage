using System;
using Microsoft.EntityFrameworkCore;

namespace frameManager.Data
{
    public class FrameDbContext:DbContext
    {
        public FrameDbContext(DbContextOptions<FrameDbContext> options ) : base(options)
        {
        }
    }
}

