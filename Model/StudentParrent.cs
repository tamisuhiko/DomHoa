using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class StudentParrent
    {
        [Key]
        public long ParrentID { get; set; }
        public string ParrentName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        [ForeignKey("UserTeacher")]
        public long CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual UserTeacher UserTeacher { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
