using System;
using System.Collections.Generic;
using System.Linq;

public class AttendanceStatistics
{
	private List<StudentAndTeacherEntity> studentsAndTeachers;

	public AttendanceStatistics()
	{
		studentsAndTeachers = new List<StudentAndTeacherEntity>();
	}

	public void RecordAttendance(StudentAndTeacherEntity studentOrTeacher)
	{
		studentsAndTeachers.Add(studentOrTeacher);
	}

	public void DisplayAttendanceStatistics()
	{
		Console.WriteLine("Attendance Statistics:");
		Console.WriteLine($"Total Students and Teachers: {studentsAndTeachers.Count}");
	}

	public void RankByGPAOrExperience()
	{
		Console.WriteLine("\nRanking Students and Teachers by GPA or Experience:");
		var rankedEntities = studentsAndTeachers.OrderByDescending(entity => entity.GPA).ThenByDescending(entity => entity.YearsOfExperience);
		int rank = 1;
		foreach (var entity in rankedEntities)
		{
			Console.WriteLine($"{rank}. {entity.FirstName} {entity.LastName} - GPA: {entity.GPA:F2}, Experience: {entity.YearsOfExperience} years");
			rank++;
		}
	}
}
