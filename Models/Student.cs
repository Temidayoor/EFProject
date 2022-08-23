using System;
using System.Collections.Generic;

#nullable disable

namespace EFProject.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string MatricNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public DateTime Dob { get; set; }
    }
}
