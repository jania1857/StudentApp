using StudentApp.DataModel.Models;

namespace StudentApp.Viewer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using var context = new EfContext();
			var students = context.Students.ToList();
			var courses = context.Courses.ToList();

			foreach (var student in students)
			{
				int courseId = student.CourseId;
				string courseName = "";
				foreach (var course in courses)
				{
					if (course.Id == courseId)
					{
						courseName = course.CourseName;
					}
				}

				Console.WriteLine($"{student.Id} | {student.Name} | {student.Address} | {student.City} | {student.PhoneNumber} | {student.Email} | {courseName}");
			}
		}
	}
}