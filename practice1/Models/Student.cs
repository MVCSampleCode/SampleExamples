using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace practice1.Models
{
    public class Student
    {
        public int StudID { get; set; }

        [DisplayName("Student Name")]
        public string StudName { get; set; }

        [DisplayName("Newly Enrolled")]
        public bool isNewlyEnrolled { get; set; }

        public string Gender { get; set; }
    }
}