using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class SchoolClass
    {
        [Key]
        public long ClassID { get; set; }
        [ForeignKey("Agency")]
        public long AgencyID { get; set; }
        public string ClassName { get; set; }
        [ForeignKey("UserTeacher")]
        public long CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Tuition Tuition { get; set; }
        public virtual ICollection<TeacherClassDetails> TeacherClassDetails { get; set; }
        public virtual Agency Agency { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual UserTeacher UserTeacher {get;set;}
    }
}
