using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class SchoolClassRepository : GenericRepository<SchoolClass>
    {
        public SchoolClassRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }

    }
}
