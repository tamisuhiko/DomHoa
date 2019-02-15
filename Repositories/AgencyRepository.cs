using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class AgencyRepository : GenericRepository<Agency>
    {
        public AgencyRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {

        }

    }
}

