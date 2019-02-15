using Microsoft.EntityFrameworkCore;
using System;

namespace Model
{
    public class PrimarySchoolsContext: DbContext
    {
        public PrimarySchoolsContext()
        {}
        public PrimarySchoolsContext(DbContextOptions<PrimarySchoolsContext> options) : base(options) {
            
        }

        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<FunctionCode> FunctionCodes { get; set; }
        public virtual DbSet<FunctionUsergroupDetails> FunctionUsergroupDetails { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentParrent> StudentParrents { get; set; }
        public virtual DbSet<TeacherClassDetails> TeacherClassDetails { get; set; }
        public virtual DbSet<Tuition> Tuitions { get; set; }
        public virtual DbSet<Usergroup> Usergroups { get; set; }
        public virtual DbSet<UserTeacher> UserTeachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SchoolClass>().HasMany(s => s.Student).WithOne(s => s.SchoolClass);

            modelBuilder.Entity<UserTeacher>().HasData(new UserTeacher() { TeacherID = 1, Username = "admin", Password = "21232f297a57a5a743894a0e4a801fc3", TeacherName = "Teacher 1", PhoneNumber = "0123", Address = "HN", Status = true, UserGroupId = 1 });
            modelBuilder.Entity<UserTeacher>().HasData(new UserTeacher() { TeacherID = 2, Username = "teacher_1", Password = "e10adc3949ba59abbe56e057f20f883e", TeacherName = "Teacher 1", PhoneNumber = "0123", Address = "HN", Status = true, UserGroupId = 1 });
            modelBuilder.Entity<UserTeacher>().HasData(new UserTeacher() { TeacherID = 3, Username = "teacher_2", Password = "e10adc3949ba59abbe56e057f20f883e", TeacherName = "Teacher 1", PhoneNumber = "0123", Address = "HN", Status = true, UserGroupId = 1 });
            modelBuilder.Entity<UserTeacher>().HasData(new UserTeacher() { TeacherID = 4, Username = "teacher_3", Password = "e10adc3949ba59abbe56e057f20f883e", TeacherName = "Teacher 1", PhoneNumber = "0123", Address = "HN", Status = true, UserGroupId = 1 });

            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 1, ParrentName = "Nguyễn Mạnh An",Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 2, ParrentName = "Bùi Duy Tùng", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 3, ParrentName = "Nguyễn Tường Anh", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 4, ParrentName = "Tô Nguyệt Anh", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 5, ParrentName = "Bùi Minh Đức", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 6, ParrentName = "Lò Thị Anh Minh", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 7, ParrentName = "Tô Minh Diệu", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 8, ParrentName = "Bùi Anh Mạnh", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });
            modelBuilder.Entity<StudentParrent>().HasData(new StudentParrent() { ParrentID = 9, ParrentName = "Tăng Nhật Minh", Gender = true, Phone = "0358466789", Address = "Hà Nội", CreateBy = 1, CreateDate = new DateTime() });

            modelBuilder.Entity<Agency>().HasData(new Agency() { AgencyID = 1, AgencyName = "Mầm non đơm hoa CS1", AgencyAddress = "Hà Nội" });
            modelBuilder.Entity<Agency>().HasData(new Agency() { AgencyID = 2, AgencyName = "Mầm non đơm hoa CS2", AgencyAddress = "Hà Nội" });
            modelBuilder.Entity<Agency>().HasData(new Agency() { AgencyID = 3, AgencyName = "Mầm non đơm hoa CS3", AgencyAddress = "Hà Nội" });
            modelBuilder.Entity<Agency>().HasData(new Agency() { AgencyID = 4, AgencyName = "Mầm non đơm hoa CS4", AgencyAddress = "Hà Nội" });

            modelBuilder.Entity<SchoolClass>().HasData(new SchoolClass() { ClassID = 1, AgencyID = 1, ClassName = "Lớp 1-2 tuổi", CreateBy = 1, CreateDate = new DateTime(2018,02,02) });
            modelBuilder.Entity<SchoolClass>().HasData(new SchoolClass() { ClassID = 2, AgencyID = 1, ClassName = "Lớp 2-3 tuổi", CreateBy = 1, CreateDate = new DateTime(2018,02,02) });
            modelBuilder.Entity<SchoolClass>().HasData(new SchoolClass() { ClassID = 3, AgencyID = 2, ClassName = "Lớp 4-5 tuổi", CreateBy = 1, CreateDate = new DateTime(2018,02,02) });
            modelBuilder.Entity<SchoolClass>().HasData(new SchoolClass() { ClassID = 4, AgencyID = 2, ClassName = "Lớp 1-2 tuổi", CreateBy = 1, CreateDate = new DateTime(2018,02,02) });
            modelBuilder.Entity<SchoolClass>().HasData(new SchoolClass() { ClassID = 5, AgencyID = 3, ClassName = "Lớp 1-2 tuổi", CreateBy = 1, CreateDate = new DateTime(2018,02,02) });

            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 1, ParrentID = 1, ClassID = 1, StudentName = "Bùi Minh Anh", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 2, ParrentID = 2, ClassID = 1, StudentName = "Nguyễn Mạnh Hải", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 3, ParrentID = 3, ClassID = 1, StudentName = "Bùi Mạnh Tùng", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 4, ParrentID = 4, ClassID = 1, StudentName = "Tô Minh Nguyệt", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 5, ParrentID = 5, ClassID = 1, StudentName = "Trần Hải Anh", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 6, ParrentID = 6, ClassID = 1, StudentName = "Lê Nguyễn Ánh Dương", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 7, ParrentID = 7, ClassID = 1, StudentName = "Bùi Minh Đức", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 8, ParrentID = 8, ClassID = 1, StudentName = "Bùi Anh Tùng", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 9, ParrentID = 9, ClassID = 1, StudentName = "Bùi Mạnh Tường", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 10, ParrentID = 1, ClassID = 2, StudentName = "Nguyễn Mạnh An", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 11, ParrentID = 2, ClassID = 2, StudentName = "Lê Minh Ngọc", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 12, ParrentID = 3, ClassID = 2, StudentName = "Đào Việt Linh", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 13, ParrentID = 4, ClassID = 2, StudentName = "Bùi Thái Nhất Linh", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 14, ParrentID = 5, ClassID = 2, StudentName = "Trần Quang Huy", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 15, ParrentID = 6, ClassID = 1, StudentName = "Nguyễn Ngọc Huy", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 16, ParrentID = 7, ClassID = 1, StudentName = "Lê Minh Sơn", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 17, ParrentID = 8, ClassID = 1, StudentName = "Trịnh Công Sơn", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 18, ParrentID = 9, ClassID = 1, StudentName = "Lê Minh Quang", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 19, ParrentID = 1, ClassID = 1, StudentName = "Phạm Hùng", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 20, ParrentID = 2, ClassID = 1, StudentName = "Nguyễn Trí Kiên", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 21, ParrentID = 3, ClassID = 1, StudentName = "Lê Minh Hải", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 22, ParrentID = 4, ClassID = 1, StudentName = "Bùi Hưng Kiên", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 23, ParrentID = 5, ClassID = 1, StudentName = "Tạ Minh Hải", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 24, ParrentID = 6, ClassID = 1, StudentName = "Nguyễn Minh An", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 25, ParrentID = 7, ClassID = 3, StudentName = "Tạ Quang Thắng", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 26, ParrentID = 8, ClassID = 3, StudentName = "Tạ Bình An", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 27, ParrentID = 9, ClassID = 3, StudentName = "Lê Minh Hoa", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 28, ParrentID = 1, ClassID = 3, StudentName = "Nguyễn Cát Phượng", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 29, ParrentID = 2, ClassID = 3, StudentName = "Tô Hải Lâm", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 30, ParrentID = 3, ClassID = 3, StudentName = "Nguyễn Mạnh Lâm", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 31, ParrentID = 4, ClassID = 3, StudentName = "Lê Thị Thu", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 32, ParrentID = 5, ClassID = 3, StudentName = "Nguyễn Bất Thành", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 33, ParrentID = 6, ClassID = 3, StudentName = "Bùi Duy Tùng", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });
            modelBuilder.Entity<Student>().HasData(new Student() { StudentID = 34, ParrentID = 7, ClassID = 3, StudentName = "Nguyễn Văn An", Gender = true, DateOfBirth = new DateTime(2000, 02, 02), StartDate = new DateTime(2018, 02, 02), CreateBy = 1, CreateDate = new DateTime(2018, 02, 02), Status = 1, PhotoPath = "/Avarta/boy.png" });

        }
    }
}
