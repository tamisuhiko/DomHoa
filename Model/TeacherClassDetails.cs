using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class TeacherClassDetails
    {
        [Key]
        public long id { get; set; }
        [ForeignKey("UserTeacher")]
        public long? TeacherID { get; set; }
        [ForeignKey("SchoolClass")]
        public long? ClassID { get; set; }
        public virtual UserTeacher UserTeacher { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
    }
}
