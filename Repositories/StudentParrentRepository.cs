using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class StudentParrentRepository : GenericRepository<StudentParrent>
    {
        public StudentParrentRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }
    }
}
