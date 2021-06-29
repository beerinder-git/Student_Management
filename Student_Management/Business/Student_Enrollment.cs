using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management.Business
{
    public class Student_Enrollment
    {
        [Key]
        public int student_Enrollment_ID { get; set; }

        public int student_ID { get; set; }
        public Student_Details Student_Details { get; set; }

        public int tutor_ID { get; set; }
        public Tutor_Details Tutor_Details { get; set; }

        public int course_ID { get; set; }
        public Course_Details Course_Details { get; set; }
    }
}
