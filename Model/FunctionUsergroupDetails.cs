using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class FunctionUsergroupDetails
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Usergroup")]
        public long UsergroupID { get; set; }
        [ForeignKey("FunctionCode")]
        public long FunctionCodeID { get; set; }

        public virtual Usergroup Usergroup { get; set; }
        public virtual FunctionCode FunctionCode { get; set; }

    }
}
