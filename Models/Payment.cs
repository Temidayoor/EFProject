using System;
using System.Collections.Generic;

#nullable disable

namespace EFProject.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public decimal? Balance { get; set; }
    }
}
