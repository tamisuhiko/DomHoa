using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Usergroup
    {
        [Key]
        public long UsergroupID { get; set; }
        public string UsergroupName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<FunctionUsergroupDetails> FunctionUsergroupDetails { get; set; }
    }
}
