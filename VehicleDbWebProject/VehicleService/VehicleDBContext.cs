using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VehicleService
{
    public abstract class VehicleDBContext : DbContext
    {
        public VehicleDBContext(DbContextOptions<VehicleDBContext> options) : base(options)
        {
        } 
        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
    }
}
