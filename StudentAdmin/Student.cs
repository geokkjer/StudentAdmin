namespace StudentAdmin;

internal class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string StudieProgram { get; set; }
    public int StudentID { get; set; }

    public Student(string name, int age, string studieProgram, int studentID)
    {
        Name = name;
        Age = age;
        StudieProgram = studieProgram;
        StudentID = studentID;

    }

    public void SkrivUtInfo(Student student)
    {
        Console.WriteLine($"Student info: " +
                          $"\nNavn: {student.Name}" +
                          $"\nAlder: {student.Age}" +
                          $"\nProgram: {student.StudieProgram}"
                          );
    }
}
