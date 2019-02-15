using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Student
    {
        [Key]
        public long StudentID { get; set; }
        [ForeignKey("StudentParrent")]
        public long? ParrentID { get; set; }
        [ForeignKey("SchoolClass")]
        public long? ClassID { get; set; }
        public string StudentName { get; set; }
        public Boolean Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        [ForeignKey("UserTeacher")]
        public long? CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string PhotoPath { get; set; }
        public int Status { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }
        public virtual UserTeacher UserTeacher { get; set; }
        public virtual StudentParrent StudentParrent { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}
