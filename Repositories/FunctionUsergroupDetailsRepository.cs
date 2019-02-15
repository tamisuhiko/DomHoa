using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class FunctionUsergroupDetailsRepository : GenericRepository<FunctionUsergroupDetails>
    {
        public FunctionUsergroupDetailsRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }
    }
}
