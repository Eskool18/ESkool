using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eSkool.Models
{
    public partial class eSkoolDBContext : DbContext
    {
        public eSkoolDBContext()
        {
        }

        public eSkoolDBContext(DbContextOptions<eSkoolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Attendence> Attendences { get; set; }
        public virtual DbSet<ChallanInfo> ChallanInfos { get; set; }
        public virtual DbSet<ChaptersInfo> ChaptersInfos { get; set; }
        public virtual DbSet<ClassAnnouncement> ClassAnnouncements { get; set; }
        public virtual DbSet<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
        public virtual DbSet<ClassTeacher> ClassTeachers { get; set; }
        public virtual DbSet<ClasssesInfo> ClasssesInfos { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<CoursesInfo> CoursesInfos { get; set; }
        public virtual DbSet<ExercisesInfo> ExercisesInfos { get; set; }
        public virtual DbSet<HelpingMeterial> HelpingMeterials { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<QuestionBank> QuestionBanks { get; set; }
        public virtual DbSet<QuestionBankMcq> QuestionBankMcqs { get; set; }
        public virtual DbSet<QuestionTypesInfo> QuestionTypesInfos { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectsInfo> SubjectsInfos { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=eSkoolDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AppicationTitle).IsUnicode(false);

                entity.Property(e => e.ApplicationBody).HasColumnType("text");

                entity.Property(e => e.ApplicationFromDate).HasColumnType("date");

                entity.Property(e => e.ApplicationToDate).HasColumnType("date");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StudentID");

                entity.Property(e => e.SubmissionDate)
                    .HasColumnType("date")
                    .HasColumnName("submissionDate");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Applications_Student");
            });

            modelBuilder.Entity<Attendence>(entity =>
            {
                entity.ToTable("Attendence");

                entity.Property(e => e.AttendenceId).HasColumnName("attendence_id");

                entity.Property(e => e.AttendenceDate)
                    .HasColumnType("date")
                    .HasColumnName("attendence_date");

                entity.Property(e => e.AttendenceStatus).HasColumnName("attendence_status");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_id");
            });

            modelBuilder.Entity<ChallanInfo>(entity =>
            {
                entity.HasKey(e => e.ChallanId)
                    .HasName("PK__ChallanI__5F721BB203B20085");

                entity.ToTable("ChallanInfo");

                entity.Property(e => e.ChallanId).HasColumnName("Challan_id");
            });

            modelBuilder.Entity<ChaptersInfo>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.ClassGrade, e.SubjectName, e.ChapterName });

                entity.ToTable("ChaptersInfo");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseId");

                entity.Property(e => e.ClassGrade).HasColumnName("classGrade");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.ChapterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chapterName");

                entity.Property(e => e.TotalExercise).HasColumnName("totalExercise");

                entity.HasOne(d => d.SubjectsInfo)
                    .WithMany(p => p.ChaptersInfos)
                    .HasForeignKey(d => new { d.CourseId, d.ClassGrade, d.SubjectName })
                    .HasConstraintName("FK_ChaptersInfo_SubjectsInfo");
            });

            modelBuilder.Entity<ClassAnnouncement>(entity =>
            {
                entity.ToTable("classAnnouncement");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<ClassSubjectTeacher>(entity =>
            {
                entity.HasKey(e => e.ClassSubjectId);

                entity.ToTable("ClassSubjectTeacher");

                entity.Property(e => e.ClassSubjectId).HasColumnName("ClassSubjectID");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TeacherID");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.ClassSubjectTeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_ClassSubjectTeacher_Teacher");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassSubjectTeachers)
                    .HasForeignKey(d => new { d.ClassGrade, d.ClassName })
                    .HasConstraintName("FK_ClassSubjectTeacher_SchoolClasses");
            });

            modelBuilder.Entity<ClassTeacher>(entity =>
            {
                entity.HasKey(e => new { e.ClassGrade, e.ClassName, e.TeacherId });

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TeacherID");
            });

            modelBuilder.Entity<ClasssesInfo>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.ClassGrade });

                entity.ToTable("ClasssesInfo");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseId");

                entity.Property(e => e.ClassGrade).HasColumnName("classGrade");

                entity.Property(e => e.TotalSubject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalSubject");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ClasssesInfos)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_ClasssesInfo_CoursesInfo1");
            });

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.Property(e => e.ComplaintId).HasColumnName("complaintID");

                entity.Property(e => e.ComplaintDate)
                    .HasColumnType("date")
                    .HasColumnName("complaintDate");

                entity.Property(e => e.ComplaintStatement)
                    .HasColumnType("text")
                    .HasColumnName("complaintStatement");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<CoursesInfo>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("CoursesInfo");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseId");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseName");

                entity.Property(e => e.TotalClasses).HasColumnName("totalClasses");
            });

            modelBuilder.Entity<ExercisesInfo>(entity =>
            {
                entity.HasKey(e => e.UniqueSyllabusId)
                    .HasName("PK_ExerciseInfo");

                entity.ToTable("ExercisesInfo");

                entity.Property(e => e.UniqueSyllabusId).HasColumnName("uniqueSyllabusID");

                entity.Property(e => e.ChapterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chapterName");

                entity.Property(e => e.ClassGrade).HasColumnName("classGrade");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseId");

                entity.Property(e => e.ExerciseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.HasOne(d => d.ChaptersInfo)
                    .WithMany(p => p.ExercisesInfos)
                    .HasForeignKey(d => new { d.CourseId, d.ClassGrade, d.SubjectName, d.ChapterName })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ExercisesInfo_ChaptersInfo");
            });

            modelBuilder.Entity<HelpingMeterial>(entity =>
            {
                entity.HasKey(e => e.MaterialId)
                    .HasName("PK_helpingMeterial");

                entity.ToTable("HelpingMeterial");

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.MaterialClass).HasColumnName("materialClass");

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialName");

                entity.Property(e => e.MaterialSubject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialSubject");

                entity.Property(e => e.MaterialType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialType");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.Property(e => e.NoticeId).HasColumnName("noticeID");

                entity.Property(e => e.NoticeFromDate)
                    .HasColumnType("date")
                    .HasColumnName("noticeFromDate");

                entity.Property(e => e.NoticeLastDate)
                    .HasColumnType("date")
                    .HasColumnName("noticeLastDate");

                entity.Property(e => e.NoticeStatement)
                    .HasColumnType("text")
                    .HasColumnName("noticeStatement");
            });

            modelBuilder.Entity<QuestionBank>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("QuestionBank");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionStatement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionTypeId).HasColumnName("questionTypeId");

                entity.Property(e => e.UniqueSyllabusId).HasColumnName("uniqueSyllabusID");
            });

            modelBuilder.Entity<QuestionBankMcq>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.Property(e => e.QuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("QuestionID");

                entity.Property(e => e.CorrectOption)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option4)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestionTypesInfo>(entity =>
            {
                entity.HasKey(e => e.QuestionTypeId);

                entity.ToTable("QuestionTypesInfo");

                entity.Property(e => e.QuestionTypeId).HasColumnName("questionTypeId");

                entity.Property(e => e.ClassGrade).HasColumnName("classGrade");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseId");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.TypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeDescription");

                entity.HasOne(d => d.SubjectsInfo)
                    .WithMany(p => p.QuestionTypesInfos)
                    .HasForeignKey(d => new { d.CourseId, d.ClassGrade, d.SubjectName })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_QuestionTypesInfo_SubjectsInfo");
            });

            modelBuilder.Entity<SchoolClass>(entity =>
            {
                entity.HasKey(e => new { e.ClassGrade, e.ClassName });

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Incharge)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StudentID");

                entity.Property(e => e.AdmissionDate).HasColumnType("date");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RollNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentCnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StudentCNIC");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => new { d.ClassGrade, d.ClassName })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Student_SchoolClasses");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubjectName);

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<SubjectsInfo>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.ClassGrade, e.SubjectName })
                    .HasName("PK_Table_1");

                entity.ToTable("SubjectsInfo");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("courseId");

                entity.Property(e => e.ClassGrade).HasColumnName("classGrade");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.TotalChapter).HasColumnName("totalChapter");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.SubjectsInfos)
                    .HasForeignKey(d => new { d.CourseId, d.ClassGrade })
                    .HasConstraintName("FK_SubjectsInfo_ClasssesInfo");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.ActiveId)
                    .HasName("PK__Table__DDEC27590394B8D1");

                entity.ToTable("Table");

                entity.Property(e => e.ActiveId).HasColumnName("Active_id");

                entity.Property(e => e.PeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("pe_time");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Table");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TeacherID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Education)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Experience)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherCnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TeacherCNIC");

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserName });

                entity.ToTable("User_Info");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
