using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using VKR_ServiceTransport.Domain.Entities;
using VKR_ServiceTransport.Ef.Persistance;



namespace VKR_ServiceTransport.Data
{
    public class TransportService
    {
        public Repair? Repair { get; set; }
        public Transport? transport { get; set; }
        public Transport? currentTransport { get; set; }
        public int currentPage { get; set; } = 0;
        public int index { get; set; } = 0;
    }
}
