using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class UserTeacherRepository : GenericRepository<UserTeacher>
    {
        public UserTeacherRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }
    }
}
