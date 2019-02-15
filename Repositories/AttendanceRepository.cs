using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class AttendanceRepository : GenericRepository<Attendance>
    {
        public AttendanceRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }
    }
}
