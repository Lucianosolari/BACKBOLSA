using BackendBolsaDeTrabajoUTN.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendBolsaDeTrabajoUTN.DBContexts
{
    public class TPContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Knowledge> Knowledges { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentKnowledge> StudentKnowledge { get; set; }
        public DbSet<StudentOffer> StudentOffers { get; set; }
        public DbSet<CVFile> CVFiles { get; set; }

        public TPContext(DbContextOptions<TPContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Company company1 = new Company()
            {
                UserId = 1,
                UserName = "MicrosoftUser",
                UserEmail = "microsoftcontact@gmail.com",
                CompanyName = "Microsoft",
                CompanyCUIT = 20447575751,
                CompanyLine = "Computación",
                CompanyAddress = "D 15",
                CompanyLocation = "Rosario",
                CompanyPostalCode = "2000",
                Password = "String1!",
                CompanyPhone = 341367898,
                CompanyWebPage = "microsoft.com",

                CompanyPersonalName = "Juan Carlos",
                CompanyPersonalSurname = "Peralta",
                CompanyPersonalJob = "Gerente",
                CompanyPersonalPhone = 22,
                CompanyRelationContact = "Vacio",
                CompanyPendingConfirmation = false,

                UserIsActive = true
            };

            Company company2 = new Company()
            {
                UserId = 2,
                UserName = "AppleUser",
                UserEmail = "applecontact@gmail.com",
                CompanyName = "Apple",
                CompanyCUIT = 20445556661,
                CompanyLine = "Textil",
                CompanyAddress = "E 18",
                CompanyLocation = "Rosario",
                CompanyPostalCode = "2000",
                Password = "String1!",
                CompanyPhone = 341334455,
                CompanyWebPage = "apple.com",

                CompanyPersonalName = "Juan Esteban",
                CompanyPersonalSurname = "Peralta",
                CompanyPersonalJob = "Gerente",
                CompanyPersonalPhone = 25,
                CompanyRelationContact = "Vacio",
                CompanyPendingConfirmation = false,

                UserIsActive = true
            };

            modelBuilder.Entity<Company>().HasData(
                company1, company2);

            modelBuilder.Entity<User>().HasDiscriminator(u => u.UserType);

            Offer offer1 = new Offer()
            {
                OfferId = 1,
                OfferTitle = "Analista de datos",
                OfferDescription = "Conocimientos avanzados en SQL",
                OfferSpecialty = "SQL",
                CompanyId = 2,
                CreatedDate = new DateTime(2023, 01, 10),

                OfferIsActive = true
            };
            Offer offer2 = new Offer()
            {
                OfferId = 2,
                OfferTitle = "Desarrollador Backend",
                OfferDescription = "Conocimientos avanzados en entorno .NET",
                OfferSpecialty = ".NET",
                CompanyId = 1,
                CreatedDate = new DateTime(2023, 05, 10),

                OfferIsActive = true
            };

            modelBuilder.Entity<Offer>().HasData(
                offer1, offer2);

            Career career1 = new Career()
            {
                CareerId = 1,
                CareerName = "Tecnicatura Universitaria en Programación",
                CareerAbbreviation = "TUP",
                CareerType = "Programación",
                CareerTotalSubjects = 20,

                CareerIsActive = true
            };
            Career career2 = new Career()
            {
                CareerId = 2,
                CareerName = "Tecnicatura Universitaria en Higiene y Seguridad",
                CareerAbbreviation = "TUHS",
                CareerType = "Seguridad",
                CareerTotalSubjects = 15,

                CareerIsActive= true
            };

            modelBuilder.Entity<Career>().HasData(
                career1, career2);

            Knowledge knowledge1 = new Knowledge()
            {
                KnowledgeId = 1,
                Type = "Programming",
                Level = "Advanced",

                KnowledgeIsActive = true
            };
            Knowledge knowledge2 = new Knowledge()
            {
                KnowledgeId = 2,
                Type = "Design",
                Level = "Intermediate",

                KnowledgeIsActive = true
            };
            Knowledge knowledge3 = new Knowledge()
            {
                KnowledgeId = 3,
                Type = "Marketing",
                Level = "Beginner",

                KnowledgeIsActive = true
            };
            modelBuilder.Entity<Knowledge>().HasData(
                knowledge1, knowledge2, knowledge3);

            Admin admin1 = new Admin()
            {
                Password = "StringAdmin1!",
                UserId = 6,
                UserName = "admin",
                NameAdmin = "AdminPepe",
                UserEmail ="luciano3924@gmail.com",

                UserIsActive = true
            };

            modelBuilder.Entity<Admin>().HasData(
                admin1);

            Student student1 = new Student()
            {
                UserId = 3,
                Name = "Manuel",
                Surname = "Ibarbia",
                UserEmail = "manuel@frro.utn.edu.ar",
                Password = "String1!",
                UserName = "manuelI",
                DocumentType = "DNI",
                DocumentNumber = 44555666,
                File = 12345,
                AltEmail = "manuelalt@gmail.com",
                CUIL_CUIT = 20445556661,
                Birth = new DateTime(2002, 12, 17),
                Sex = "Masculino",
                CivilStatus = "Soltero",

                FamilyStreet = "Calle Principal",
                FamilyStreetNumber = 123,
                FamilyStreetLetter = "A",
                FamilyFloor = 2,
                FamilyDepartment = "4B",
                FamilyCountry = "Argentina",
                FamilyProvince = "Buenos Aires",
                FamilyLocation = "Ciudad Autónoma de Buenos Aires",
                FamilyPersonalPhone = 123456789,
                FamilyOtherPhone = 987654321,

                PersonalStreet = "Avenida Principal",
                PersonalStreetNumber = 456,
                PersonalStreetLetter = "B",
                PersonalFloor = 1,
                PersonalDepartment = "Depto. 2",
                PersonalCountry = "Argentina",
                PersonalProvince = "Córdoba",
                PersonalLocation = "Córdoba Capital",
                PersonalPersonalPhone = 987654321,
                PersonalOtherPhone = 123456789,

                Specialty = "Sistemas",
                ApprovedSubjectsQuantity = 10,
                SpecialtyPlan = 2021,
                CurrentStudyYear = 2,
                StudyTurn = "Tarde",
                AverageMarksWithPostponement=8,
                AverageMarksWithoutPostponement=8,
                CollegeDegree="Sistemas",

                SecondaryDegree = "Completo",
                Observations = "Fanático de linux",

                UserIsActive = true
            };
            Student student2 = new Student()
            {
                UserId = 4,
                Name = "Luciano",
                Surname = "Solari",
                UserEmail = "luciano@frro.utn.edu.ar",
                Password = "String1!",
                UserName = "lucianoS",
                DocumentType = "DNI",
                DocumentNumber = 33444555,
                File = 12346,
                AltEmail = "lucianoalt@gmail.com",
                CUIL_CUIT = 203334445551,
                Birth = new DateTime(1998, 5, 12),
                Sex = "Masculino",
                CivilStatus = "Soltero",

                FamilyStreet = "Calle asdasd",
                FamilyStreetNumber = 12,
                FamilyStreetLetter = "AA",
                FamilyFloor = 22,
                FamilyDepartment = "5B",
                FamilyCountry = "Argentina",
                FamilyProvince = "Santa Fe",
                FamilyLocation = "Rosario",
                FamilyPersonalPhone = 123456789,
                FamilyOtherPhone = 987654321,

                PersonalStreet = "Avenida Principal",
                PersonalStreetNumber = 456,
                PersonalStreetLetter = "B",
                PersonalFloor = 1,
                PersonalDepartment = "Depto. 2",
                PersonalCountry = "Argentina",
                PersonalProvince = "Córdoba",
                PersonalLocation = "Córdoba Capital",
                PersonalPersonalPhone = 987654321,
                PersonalOtherPhone = 123456789,

                Specialty = "Sistemas",
                ApprovedSubjectsQuantity = 10,
                SpecialtyPlan = 2021,
                CurrentStudyYear = 2,
                StudyTurn = "Tarde",
                AverageMarksWithPostponement = 6,
                AverageMarksWithoutPostponement = 7,
                CollegeDegree = "Sistemas",

                SecondaryDegree = "Completo",
               
                Observations = "Fanático de linux",

                UserIsActive = true
            };
            Student student3 = new Student()
            {
                UserId = 5,
                Name = "Santiago",
                Surname = "Caso",
                UserEmail = "santiago@frro.utn.edu.ar",
                Password = "String1!",
                UserName = "santiagoC",
                DocumentNumber = 55666777,
                DocumentType = "DNI",
                File = 12347,
                AltEmail = "santiagoalt@gmail.com",
                CUIL_CUIT = 20556667771,
                Birth = new DateTime(2003, 4, 10),
                Sex = "Masculino",
                CivilStatus = "Soltero",
                FamilyStreet = "Calle asdasd",
                FamilyStreetNumber = 12,
                FamilyStreetLetter = "AA",
                FamilyFloor = 22,
                FamilyDepartment = "5B",
                FamilyCountry = "Argentina",
                FamilyProvince = "Santa Fe",
                FamilyLocation = "Rosario",
                FamilyPersonalPhone = 123456789,
                FamilyOtherPhone = 987654321,

                PersonalStreet = "Avenida Principal",
                PersonalStreetNumber = 456,
                PersonalStreetLetter = "B",
                PersonalFloor = 1,
                PersonalDepartment = "Depto. 2",
                PersonalCountry = "Argentina",
                PersonalProvince = "Córdoba",
                PersonalLocation = "Córdoba Capital",
                PersonalPersonalPhone = 987654321,
                PersonalOtherPhone = 123456789,

                Specialty = "Sistemas",
                ApprovedSubjectsQuantity = 10,
                SpecialtyPlan = 2002,
                CurrentStudyYear = 2,
                StudyTurn = "Tarde",
                AverageMarksWithPostponement = 6,
                AverageMarksWithoutPostponement = 7,
                CollegeDegree = "Sistemas",

                SecondaryDegree = "Completo",
                
                Observations = "Fanático de Visual Studio",

                UserIsActive = true
            };

            modelBuilder.Entity<Student>().HasData(
                student1, student2, student3);

            modelBuilder.Entity<Company>()
                .HasMany<Offer>(c => c.AnnouncedOffers)
                .WithOne(o => o.Company);

            modelBuilder.Entity<Student>()
            .HasMany(s => s.Knowledges)
            .WithMany(k => k.Students)
            .UsingEntity<StudentKnowledge>(
                j => j
                    .HasOne(sk => sk.Knowledge)
                    .WithMany(k => k.StudentKnowledges)
                    .HasForeignKey(sk => sk.KnowledgeId),
                    
                j => j
                    .HasOne(sk => sk.Student)
                    .WithMany(s => s.StudentKnowledges)
                    .HasForeignKey(sk => sk.UserId),
                    
                j =>
                {
                    j.HasKey(sk => new { sk.UserId, sk.KnowledgeId });
                    j.ToTable("StudentKnowledge");
                    j.HasData(
                        new StudentKnowledge { UserId = 4, KnowledgeId = 1, StudentKnowledgeIsActive=true},
                        new StudentKnowledge { UserId = 3, KnowledgeId = 2, StudentKnowledgeIsActive = true }
                    );
                }
            );

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Careers)
                .WithMany(c => c.Students)
                .UsingEntity<StudentCareer>(
                    j => j.HasOne(c => c.Career)
                          .WithMany()
                          .HasForeignKey(c => c.CareerId),
                          
                    j => j.HasOne(s => s.Student)
                          .WithMany()
                          .HasForeignKey(s => s.StudentId),
                          
                    j =>
                    {
                        j.ToTable("StudentCareer");
                        j.HasKey(k => new { k.StudentId, k.CareerId });
                        j.HasData(
                            new StudentCareer { StudentId = 4, CareerId = 1, StudentCareerIsActive= true},
                            new StudentCareer { StudentId = 5, CareerId = 2, StudentCareerIsActive =true}
                        );
                    }
                );

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Offers)
                .WithMany(o => o.Students)
                .UsingEntity<StudentOffer>(
                    j => j
                        .HasOne(so => so.Offer)
                        .WithMany(o => o.StudentOffers)
                        .HasForeignKey(so => so.OfferId),
                        
                    j => j
                        .HasOne(so => so.Student)
                        .WithMany(s => s.StudentOffers)
                        .HasForeignKey(so => so.StudentId),
                        
                    j =>
                    {
                        j.ToTable("StudentOffer");
                        j.HasData(
                            new StudentOffer { OfferId = 1, StudentId = 4, StudentOfferIsActive= true },
                            new StudentOffer { OfferId = 2, StudentId = 5, StudentOfferIsActive= true }
                        );
                    });

            base.OnModelCreating(modelBuilder);
        }
    }
}