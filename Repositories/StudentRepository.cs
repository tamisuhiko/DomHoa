using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositories
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(PrimarySchoolsContext primarySchoolsContext) : base(primarySchoolsContext)
        {
        }
    }
}
