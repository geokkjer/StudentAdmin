

using System.Data.Common;

namespace StudentAdmin;
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int[] Subjects { get; set; }
    public int StudentID { get; set; }

    public Student(string name, int age, int[] subjects, int studentID)
    {
        Name = name;
        Age = age;
        Subjects = subjects;
        StudentID = studentID;

    }
    public void SkrivUtInfo()
    {
        Console.Clear();
        Console.WriteLine(string.Concat(Enumerable.Repeat("*", 22)));
        Console.WriteLine($"Student info: " +
                          $"\nNavn: {Name}" +
                          $"\nAlder: {Age}" +
                          "\nTar fag: "
                          );
    }
}