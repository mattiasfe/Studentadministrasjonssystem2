namespace Studentadministrasjonssystem;

public class Fag
{
    private int fagkode;
    private string fagnavn;
    private int antallStudiepoeng;

    public Fag(int fagkode, string fagnavn, int antallStudiepoeng)
    {
        this.fagkode = fagkode;
        this.fagnavn = fagnavn;
        this.antallStudiepoeng = antallStudiepoeng;
    }
    
    public void GetFagkode(int fagkode)
    {
        Console.WriteLine($"Fagkode: {fagkode}");
    }
    public void GetFagnavn(string fagnavn)
    {
        var karakterer = new Karakterer(6);
        Console.WriteLine($"Fagnavn: {fagnavn}");
        Console.WriteLine($"karakter: {karakterer}");
    }
    public void GetAntallStudiepoeng(int antallStudiepoeng)
    {
        Console.WriteLine($"AntallStudiepoeng: {antallStudiepoeng}");
    }
}