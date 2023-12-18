using System;
using System.Collections.Generic;
using System.Linq;

public class Student : PersonEntity
{
    public int StudentId { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }
    public int AttendanceCount { get; private set; }

    public Student(string firstName, string lastName, DateTime birthDate, string address, int studentId, string major, double gpa, int attendanceCount)
        : base(firstName, lastName, birthDate, address)
    {
        this.StudentId = studentId;
        this.Major = major;
        this.GPA = gpa;
        this.AttendanceCount = attendanceCount;
    }

    public override void DisplayPersonInfo()
    {
        base.DisplayPersonInfo();
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"GPA: {GPA:F2}");
        Console.WriteLine($"Attendance Count: {AttendanceCount}");
    }

    public void StudyHard()
    {
        Console.WriteLine($"Student {FirstName} is studying hard for exams.");
    }

    public void AttendClass()
    {
        Console.WriteLine($"Student {FirstName} is attending a class in {Major}.");
        AttendanceCount++;
    }

    public void PlaySports()
    {
        Console.WriteLine($"Student {FirstName} is playing sports in their free time.");
    }
}