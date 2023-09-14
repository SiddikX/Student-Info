using StudentManagement.Models;

namespace StudentManagement.SeedData
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            SeedClasses(context);
            SeedStudents(context);
        }

        private static void SeedClasses(ApplicationDbContext context)
        {
            // Check if the Classes table already has data
            if (context.Classes.Any())
            {
                return; // Database has already been seeded
            }

            // Add initial class data
            var classes = new Class[]
            {
                new Class { Name = "One", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new Class { Name = "Two", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new Class { Name = "Three", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new Class { Name = "Four", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                new Class { Name = "Five", CreatedDate = DateTime.Now, ModificationDate = DateTime.Now },
                // Add more class entries as needed
            };

            foreach (var c in classes)
            {
                context.Classes.Add(c);
            }

            context.SaveChanges();
        }

        private static void SeedStudents(ApplicationDbContext context)
        {
            // Check if the Students table already has data
            if (context.Students.Any())
            {
                return; // Database has already been seeded
            }

            // Add initial student data
            var students = new Student[]
            {
                new Student
                {
                    Name = "Sadman",
                    ClassId = 1, // Assuming "One" class has Id 1
                    DOB = new DateTime(2017, 1, 2),
                    Gender = 1, // Male
                    CreatedDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },
                new Student
                {
                    Name = "Sudipto",
                    ClassId = 2, // Assuming "Two" class has Id 2
                    DOB = new DateTime(2013, 6, 18),
                    Gender = 1, // Male
                    CreatedDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },
                new Student
                {
                    Name = "Ira",
                    ClassId = 1, // Assuming "One" class has Id 1
                    DOB = new DateTime(2010, 12, 12),
                    Gender = 2, // Female
                    CreatedDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },

                new Student
                {
                    Name = "Emon",
                    ClassId = 4,
                    DOB = new DateTime(2010, 12, 12),
                    Gender = 1,
                    CreatedDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },

            };

            foreach (var s in students)
            {
                context.Students.Add(s);
            }

            context.SaveChanges();
        }
    }
}
