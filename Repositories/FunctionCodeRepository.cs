using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class FunctionCodeRepository : GenericRepository<FunctionCode>
    {
        public FunctionCodeRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {

        } 
    }
}
