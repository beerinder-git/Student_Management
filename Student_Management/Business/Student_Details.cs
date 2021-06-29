using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management.Business
{
    public class Student_Details
    {
        [Key]
        public int student_ID { get; set; }
        public string student_Name { get; set; }
        public string student_Email { get; set; }
        public string student_Mobile { get; set; }
        public string student_Address { get; set; }
    }
}
