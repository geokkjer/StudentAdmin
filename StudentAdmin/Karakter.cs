namespace StudentAdmin;

internal class Karakter
{
    public Student Student { get; set; }
    public Fag Fag { get; set; }
    public int KarakterVerdi { get; set; }

    public Karakter(Student student, Fag fag, int karakterVerdi)
    {
        Student = student;
        Fag = fag;
        KarakterVerdi = karakterVerdi;
    }

    public void SkrivUtInfo(Karakter karakter)
    {
        Console.WriteLine(
            $"Student: {karakter.Student}\n" +
            $"Fag: {karakter.Fag}" +
            $"Karakter: {karakter.KarakterVerdi}\n"
        );
    }
}