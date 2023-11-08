using System;
using System.Collections.Generic;

namespace HellloWebApp.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public double Grade { get; set; }
    }
}
