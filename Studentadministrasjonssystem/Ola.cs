namespace Studentadministrasjonssystem;

public class Ola
{
    private string name;
    private int age;
    private int studentId;
    string studieProgram;
    private int karakterer;
    private int fagkode;
    private string fagnavn;
    private int antallStudiepoeng;
    
    // Ola olaHenriksen = new Ola("Henrik", 25, 277, "Medisin", 4, "NevroKirugi", 252, 23);
    // Herman hermanJensen = new Herman("Jensen", 22, 2278, "IT", 5, 20, "Python", 222);
    // private List<Ola> olaListe = [olaHenriksen, hermanJensen];

    public Ola(string firstname, string lastname, int age, int studentId, string studieProgram, int karakterer, string fagnavn, int antallStudiepoeng, int fagkode)
    {
        
        this.studentId = studentId;
        this.age = age;
        this.name = firstname + " " + lastname;
        this.studieProgram = studieProgram;
        this.karakterer = karakterer;
        this.fagkode = fagkode;
        this.fagnavn = fagnavn;
        this.antallStudiepoeng = antallStudiepoeng;
    }

    public Ola(string firstname, int lastname, int i, string medisin, int studieProgram1, string nevrokirugi, int fagnavn1, int antallStudiepoeng1)
    {
       
    }


    // public void GetName(string name)
    // {
    //     Console.WriteLine($"Navn: {name}");
    // }
    // public void GetAge(int age)
    // {
    //     Console.WriteLine($"Alder: {age}");;
    // }
    // public void GetStudentId(int studentId)
    // {
    //     Console.WriteLine($"Id: {studentId}");
    // }
    // public void GetStudeieProgram(string studieProgram)
    // {
    //     Console.WriteLine($"StudieProgram: {studieProgram}");
    // }
    // public void GetFagkode(int fagkode)
    // {
    //     Console.WriteLine($"Fagkode: {fagkode}");
    // }
    // public void GetFagnavn(string fagnavn)
    // {
    //     Console.WriteLine($"Fagnavn: {fagnavn}");
    // }
    // public void GetAntallStudiepoeng(int antallStudiepoeng)
    // {
    //     Console.WriteLine($"AntallStudiepoeng: {antallStudiepoeng}");
    // }
    // public void GetKarakterer(int karakterer)
    // {
    //     Console.WriteLine($"Karakterer: {karakterer}");
    // }
}