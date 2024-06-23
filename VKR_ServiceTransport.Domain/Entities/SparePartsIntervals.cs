using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKR_ServiceTransport.Domain.Entities
{
    public class SparePartsIntervals
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string? IntervalByDate { get; set; }
        public string? IntervalByMileage { get; set;}
    }
}
