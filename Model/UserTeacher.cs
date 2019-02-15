using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class UserTeacher
    {
        [Key]
        public long TeacherID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeacherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Boolean Status { get; set; }
        public long UserGroupId { get; set; }
        [ForeignKey("TeacherID")]
        public virtual ICollection<TeacherClassDetails> TeacherClassDetail { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<StudentParrent> StudentParrent { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }

    }
}
