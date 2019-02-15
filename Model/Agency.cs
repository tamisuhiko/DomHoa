using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Agency
    {
        [Key]
        public long AgencyID { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        
        public virtual ICollection<SchoolClass> SchoolClass { get; set; }
    }
}
