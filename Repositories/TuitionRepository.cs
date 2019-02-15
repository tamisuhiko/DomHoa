using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class TuitionRepository : GenericRepository<Tuition>
    {
        public TuitionRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }
    }
}
