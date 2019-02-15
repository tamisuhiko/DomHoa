using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Tuition
    {
        [Key]
        public long TuitionID { get; set; }
        [ForeignKey("SchoolClass")]
        public long ClassID { get; set; }
        public string TuitionName { get; set; } 
        public decimal TuitionValue { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }
    }
}
