using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management.Business
{
    public class Course_Details
    {
        [Key]
        public int course_ID { get; set; }
        public string course_Name { get; set; }
        public DateTime start_Date { get; set; }
        public DateTime finish_Date { get; set; }
    }
}
