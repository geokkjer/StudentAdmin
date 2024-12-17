namespace StudentAdmin;

internal class Grade
{
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public int GradeValue { get; set; }

    public Grade(int studentid, int subjectid, int gradeValue)
    {
        StudentId = studentid;
        SubjectId = subjectid;
        GradeValue = gradeValue;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Fag: {SubjectId} Karakter: {GradeValue}");
        Console.WriteLine(string.Concat(Enumerable.Repeat("*", 22)));
    }
}