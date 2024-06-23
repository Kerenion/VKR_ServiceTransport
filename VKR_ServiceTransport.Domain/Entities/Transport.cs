using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKR_ServiceTransport.Domain.Entities
{
	public class Transport
	{
		public int Id { get; set; }
		public string Brand { get; set; } = null!;
		public string Model { get; set; } = null!;
        public string StateNumber { get; set; } = null!;
		public int Mileage { get; set; }
		public int VIN { get; set; }
        public List<Notice>? Notices { get; set; }
		public List<Repair>? Repairs { get; set; }
        public List<SparePartsIntervals> SparePartsIntervals { get; set; }
    }
}
