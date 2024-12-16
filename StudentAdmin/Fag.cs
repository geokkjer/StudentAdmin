namespace StudentAdmin;

internal class Fag
{
   public int FagKode{get;set;}
   public string FagNavn{get;set;}
   public int AntallStudiePoeng {get;set;}

   public Fag(int fagKode, string fagNavn, int antallStudiePoeng)
   {
      FagKode = fagKode;
      FagNavn = fagNavn;
      AntallStudiePoeng = antallStudiePoeng;
   }

   public void SkrivUtInfo(Fag fag){
      Console.WriteLine($"\nKode: {fag.FagKode}");
      Console.WriteLine($"\nNavn: {fag.FagNavn}");
      Console.WriteLine($"\nPoeng: {fag.AntallStudiePoeng}");
   }
}