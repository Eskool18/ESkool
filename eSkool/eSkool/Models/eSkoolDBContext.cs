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

        public virtual DbSet<ChaptersInfo> ChaptersInfos { get; set; }
        public virtual DbSet<ClassTeacher> ClassTeachers { get; set; }
        public virtual DbSet<ClasssesInfo> ClasssesInfos { get; set; }
        public virtual DbSet<CoursesInfo> CoursesInfos { get; set; }
        public virtual DbSet<ExercisesInfo> ExercisesInfos { get; set; }
        public virtual DbSet<QuestionBank> QuestionBanks { get; set; }
        public virtual DbSet<QuestionBankMcq> QuestionBankMcqs { get; set; }
        public virtual DbSet<QuestionTypesInfo> QuestionTypesInfos { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubjectsInfo> SubjectsInfos { get; set; }
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

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.ClassTeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_ClassTeachers_Teacher");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassTeachers)
                    .HasForeignKey(d => new { d.ClassGrade, d.ClassName })
                    .HasConstraintName("FK_ClassTeachers_SchoolClasses");
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
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Student_Info");

                entity.ToTable("Student");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

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
