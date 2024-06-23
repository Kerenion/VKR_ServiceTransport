using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKR_ServiceTransport.Domain.Entities
{
    public class Repair
    {
        [Key]
        public int Id { get; set; }
        public string WhatWasDone { get; set; } = null!;
        public int CurrentMileage { get; set; }
        public DateOnly Date {  get; set; }


        public decimal CostSparePart { get; set; }
        public decimal CostWork { get; set; }
        public decimal CostTotal { get; set; }


        public int PartNumbers { get; set; }
        public string Comment { get; set; } = null!;
    }
}
