using Model;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly PrimarySchoolsContext _primarySchoolsContext = new PrimarySchoolsContext();
        private AgencyRepository _agencyRepository;
        private AttendanceRepository _attendanceRepository;
        private FunctionCodeRepository _functionCodeRepository;
        private FunctionUsergroupDetailsRepository _functionUsergroupDetailsRepository;
        private SchoolClassRepository _schoolClassRepository;
        private StudentParrentRepository _studentParrentRepository;
        private StudentRepository _studentRepository;
        private TeacherClassDetailsRepository _teacherClassDetailsRepository;
        private TuitionRepository _tuitionRepository;   
        private UsergroupRepository _usergroupRepository;
        private UserTeacherRepository _userTeacherRepository;

        public UnitOfWork()
        {
        }

        public AgencyRepository AgencyRepository
        {
            get
            {
                if (this._agencyRepository == null)
                {
                    this._agencyRepository = new AgencyRepository(_primarySchoolsContext);
                }
                return this._agencyRepository;
            }
        }

        public AttendanceRepository AttendanceRepository
        {
            get
            {
                if (this._attendanceRepository == null)
                {
                    this._attendanceRepository = new AttendanceRepository(_primarySchoolsContext);
                }
                return this._attendanceRepository;
            }
        }

        public FunctionCodeRepository FunctionCodeRepository
        {
            get
            {
                if (this._functionCodeRepository == null)
                {
                    this._functionCodeRepository = new FunctionCodeRepository(_primarySchoolsContext);
                }
                return this._functionCodeRepository;
            }
        }

        public FunctionUsergroupDetailsRepository FunctionUsergroupDetailsRepository
        {
            get
            {
                if (this._functionUsergroupDetailsRepository == null)
                {
                    this._functionUsergroupDetailsRepository = new FunctionUsergroupDetailsRepository(_primarySchoolsContext);
                }
                return this._functionUsergroupDetailsRepository;
            }
        }

        public SchoolClassRepository SchoolClassRepository
        {
            get
            {
                if (this._schoolClassRepository == null)
                {
                    this._schoolClassRepository = new SchoolClassRepository(_primarySchoolsContext);
                }
                return this._schoolClassRepository;
            }
        }

        public StudentParrentRepository StudentParrentRepository
        {
            get
            {
                if (this._studentParrentRepository == null)
                {
                    this._studentParrentRepository = new StudentParrentRepository(_primarySchoolsContext);
                }
                return this._studentParrentRepository;
            }
        }

        public StudentRepository StudentRepository
        {
            get
            {
                if (this._studentRepository == null)
                {
                    this._studentRepository = new StudentRepository(_primarySchoolsContext);
                }
                return this._studentRepository;
            }
        }

        public TeacherClassDetailsRepository TeacherClassDetailsRepository
        {
            get
            {
                if (this._teacherClassDetailsRepository == null)
                {
                    this._teacherClassDetailsRepository = new TeacherClassDetailsRepository(_primarySchoolsContext);
                }
                return this._teacherClassDetailsRepository;
            }
        }

        public TuitionRepository TuitionRepository
        {
            get
            {
                if (this._tuitionRepository == null)
                {
                    this._tuitionRepository = new TuitionRepository(_primarySchoolsContext);
                }
                return this._tuitionRepository;
            }
        }

        public UsergroupRepository UsergroupRepository
        {
            get
            {
                if (this._usergroupRepository == null)
                {
                    this._usergroupRepository = new UsergroupRepository(_primarySchoolsContext);
                }
                return this._usergroupRepository;
            }
        }

        public UserTeacherRepository UserTeacherRepository
        {
            get
            {
                if (this._userTeacherRepository == null)
                {
                    this._userTeacherRepository = new UserTeacherRepository(_primarySchoolsContext);
                }
                return this._userTeacherRepository;
            }
        }

        public int SaveChange()
        {
            return this._primarySchoolsContext.SaveChanges();
        }

        public void Commit()
        {
            this._primarySchoolsContext.Database.CommitTransaction();
        }
    }
}
