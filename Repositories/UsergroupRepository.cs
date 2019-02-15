using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class UsergroupRepository : GenericRepository<Usergroup>
    {
        public UsergroupRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {      
        }
    }
}
