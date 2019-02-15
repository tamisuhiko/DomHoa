using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class FunctionCode
    {
        [Key]
        public long FunctionCodeID { get; set; }
        public long Code { get; set; }
        public string Description { get; set; }
        public ICollection<FunctionUsergroupDetails> FunctionUsergroupDetails { get; set; }
    }
}
