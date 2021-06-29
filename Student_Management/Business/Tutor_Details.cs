using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management.Business
{
    public class Tutor_Details
    {
        [Key]
        public int tutor_ID { get; set; }
        public string tutor_Name { get; set; }
        public string tutor_Email { get; set; }
        public string tutor_Mobile { get; set; }
        public string tutor_Address { get; set; }

    }
}
