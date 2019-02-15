using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Attendance
    {
        [Key]
        public long AttendanceID { get; set; }
        [ForeignKey("Student")]
        public long StudentID { get; set; }
        [ForeignKey("UserTeacher")]
        public long AttendanceBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Status { get; set; }

        public virtual UserTeacher UserTeacher { get; set; }
        public virtual Student Student { get; set; }
    }
}
