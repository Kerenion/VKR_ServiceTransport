using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKR_ServiceTransport.Domain.Entities
{
    public class Notice
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public int MileageNotify { get; set; }
        public DateOnly DateNotify { get; set; }
        public DateOnly Date { get; set; }
        public string Comment { get; set; } = null!;
    }
}
