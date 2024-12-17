namespace StudentAdmin;

internal class Subject
{
   public int SubjectCode {get;set;}
   public string Name{get;set;}
   public int Points {get;set;}

   public Subject(int code, string name, int points)
   {
      SubjectCode = code;
      Name = name;
      Points = points;
   }

   public void SkrivUtInfo(){
      Console.WriteLine($"Navn: {Name} Kode: {SubjectCode}  Poeng: {Points}");
   }
}