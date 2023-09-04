using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApiIncidenceProContext : DbContext
    {
        public ApiIncidenceProContext(DbContextOptions<ApiIncidenceProContext> options) : base(options)
        {
        }
    }
}