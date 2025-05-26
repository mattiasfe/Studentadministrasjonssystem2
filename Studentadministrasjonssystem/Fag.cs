namespace Studentadministrasjonssystem;

public class Fag
{
     private string _fagNavn;
     private int _fagKode;
     private int _antallStudiepoeng;

     public Fag(string fagNavn, int fagKode, int antallStudiepoeng)
     {
          _fagNavn = fagNavn;
          _fagKode = fagKode;
          _antallStudiepoeng = antallStudiepoeng;
     }

     public void skrivUtInfo()
     {
          Console.WriteLine($"""
                            Faget:{_fagNavn},
                            FagKode:{_fagKode}
                            Studiepoeng: {_antallStudiepoeng}
                            """);
     }
}