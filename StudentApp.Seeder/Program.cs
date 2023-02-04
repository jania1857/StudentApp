using StudentApp.DataModel.Models;

namespace StudentApp.Seeder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using var context = new EfContext();
			Console.WriteLine("Dodaj nowych studentów i kursy");

			var students = new[]
			{
				new Student(){ Name = "John Doo", Address = "Kolobrzeska 5", City = "Koszalin", PhoneNumber = "123456789", Email = "johndoo@example.com", CourseId = 1 },
				new Student(){ Name = "Michael Jordan", Address = "Falata 23/4", City = "Kolobrzeg", PhoneNumber = "987654321", Email = "michaeljordan@example.com", CourseId = 3 },
				new Student(){ Name = "Adam Adamski", Address = "Redlo 69/12", City = "Redlo", PhoneNumber = "696969696", Email = "adamadamski@example.com", CourseId = 1 },
				new Student(){ Name = "Wanda Kowalska", Address = "Sportowa 15", City = "Nowogard", PhoneNumber = "666666666", Email = "wandakowalska@example.com", CourseId = 2 },
				new Student(){ Name = "Ferdynand Kiepski", Address = "Cwiartki 3/4", City = "Wroclaw", PhoneNumber = "000000000", Email = "ferdynandkiepski@example.com", CourseId = 4 },
			};

			foreach (var s in students)
			{
				context.Students.Add(s);
			}

			var courses = new[]
			{
				new Course(){ CourseName = "Programming in C#"},
				new Course(){ CourseName = "Programming in Python"},
				new Course(){ CourseName = "Programming in Java",},
				new Course(){ CourseName = "Programming in Ruby"},
			};

			foreach (var c in courses)
			{ 
				context.Courses.Add(c);
			}

			context.SaveChanges();
		}
	}
}