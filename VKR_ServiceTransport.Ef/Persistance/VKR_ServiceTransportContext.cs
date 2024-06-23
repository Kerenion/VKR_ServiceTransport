using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKR_ServiceTransport.Domain.Entities;

namespace VKR_ServiceTransport.Ef.Persistance
{
	public class VKR_ServiceTransportContext : DbContext
	{
		public DbSet<Transport> Transports { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<SparePartsIntervals> SparePartsIntervals { get; set; }

        public VKR_ServiceTransportContext(DbContextOptions<VKR_ServiceTransportContext> options) : base(options) 
		{
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
		}
	}
}
